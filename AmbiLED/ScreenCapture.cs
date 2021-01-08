using System;
using SlimDX.Direct3D9;
using System.ComponentModel;

namespace AmbiLED {
    class ScreenCapture : IDisposable {
        private const int COLORS_PER_LED = 3;
        private const int BYTES_PER_PIXEL = 4;

        private BackgroundWorker backgroundWorker = new BackgroundWorker();

        public ScreenCapture() {
            backgroundWorker.DoWork += BackgroundWorkerDoWork;
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
                //TODO
            }
        }

        public void Dispose() {
            throw new NotImplementedException();
        }
    }
}
