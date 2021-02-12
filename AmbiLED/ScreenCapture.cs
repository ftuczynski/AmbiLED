using System;
using SlimDX;
using SlimDX.Direct3D9;
using System.ComponentModel;

namespace AmbiLED {
    class ScreenCapture : IDisposable {
        private const int COLORS_PER_LED = 3;
        private const int BYTES_PER_PIXEL = 4;

        private BackgroundWorker backgroundWorker = new BackgroundWorker();

        private byte[] colorBufferTopLeft = new byte[BYTES_PER_PIXEL];
        private byte[] colorBufferTopRight = new byte[BYTES_PER_PIXEL];
        private byte[] colorBufferCenter = new byte[BYTES_PER_PIXEL];
        private byte[] colorBufferBottomLeft = new byte[BYTES_PER_PIXEL];
        private byte[] colorBufferBottomRight = new byte[BYTES_PER_PIXEL];
        private int[] colorBuffer = new int[COLORS_PER_LED];

        public ScreenCapture() {
            backgroundWorker.DoWork += BackgroundWorkerDoWork;
            backgroundWorker.WorkerSupportsCancellation = true;
        }

        public void Start() {
            if (!backgroundWorker.IsBusy)
                backgroundWorker.RunWorkerAsync();
        }

        public void Stop() {
            if (backgroundWorker.IsBusy)
                backgroundWorker.CancelAsync();
        }

        private void BackgroundWorkerDoWork(object sender, DoWorkEventArgs e) {
            Direct3D direct3D = new Direct3D();

            PresentParameters presentParameters = new PresentParameters();
            presentParameters.Windowed = true;
            presentParameters.SwapEffect = SwapEffect.Discard;
            Device device = new Device(direct3D, 0, DeviceType.Hardware, IntPtr.Zero, CreateFlags.SoftwareVertexProcessing, presentParameters);

            while (!backgroundWorker.CancellationPending) {
                Surface surface = Surface.CreateOffscreenPlain(device, Program.ScreenWidth, Program.ScreenHeight, Format.A8R8G8B8, Pool.Scratch);
                device.GetFrontBufferData(0, surface);

                DataRectangle dataRectangle = surface.LockRectangle(LockFlags.None);
                DataStream dataStream = dataRectangle.Data;

                lock (SpotSet.Lock) {
                    foreach(Spot spot in SpotSet.Spots) {
                        if (spot.TopLeft.PosDx >= 0 && spot.TopRight.PosDx >= 0 && spot.BottomLeft.PosDx >= 0 && spot.BottomRight.PosDx >= 0) {
                            dataStream.Position = spot.TopLeft.PosDx;
                            dataStream.Read(colorBufferTopLeft, 0, 4);

                            dataStream.Position = spot.TopRight.PosDx;
                            dataStream.Read(colorBufferTopRight, 0, 4);

                            dataStream.Position = spot.Center.PosDx;
                            dataStream.Read(colorBufferCenter, 0, 4);

                            dataStream.Position = spot.BottomLeft.PosDx;
                            dataStream.Read(colorBufferBottomLeft, 0, 4);

                            dataStream.Position = spot.BottomRight.PosDx;
                            dataStream.Read(colorBufferBottomRight, 0, 4);

                            AverageValues();
                            
                            spot.SetColor(colorBuffer[2], colorBuffer[1], colorBuffer[0]);  //BGR -> RGB
                        }
                    }
                }
                surface.UnlockRectangle();
                surface.Dispose();
            }
            device.Dispose();
            direct3D.Dispose();
            e.Cancel = true;
        }

        private void AverageValues() {
            for(int i = 0; i < COLORS_PER_LED; i++) {
                int temp = (int)(colorBufferTopLeft[i] 
                    + colorBufferTopRight[i] 
                    + colorBufferCenter[i] 
                    + colorBufferBottomLeft[i] 
                    + colorBufferBottomRight[i]) / 5;
                colorBuffer[i] = (byte)temp;
            }
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing) {
            if (disposing) {
                Stop();
                backgroundWorker.Dispose();
            }
        }
    }
}
