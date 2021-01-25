using System;
using System.ComponentModel;
using System.IO.Ports;

namespace AmbiLED {
    class SerialStream : IDisposable {

        private readonly byte[] MESSAGE_PREAMBLE = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09 };
        private const int COLORS_PER_LED = 3;

        private BackgroundWorker backgroundWorker = new BackgroundWorker();
        private SerialPort serialPort;

        public SerialStream() {
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.WorkerSupportsCancellation = true;
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
            try {
                serialPort = new SerialPort(Settings.ComPort, 115200);
                serialPort.Open();
                while (!backgroundWorker.CancellationPending) {
                    byte[] outputStream = GetOutputStream();
                    serialPort.Write(outputStream, 0, outputStream.Length);
                }
            }
            catch (Exception ex) {
                Console.Write(ex);
            }
            finally {
                if (serialPort != null && serialPort.IsOpen) {
                    serialPort.Close();
                    serialPort.Dispose();
                }
            }
            e.Cancel = true;
        }

        private byte[] GetOutputStream() {
            byte[] outputStream;
            int counter = MESSAGE_PREAMBLE.Length;

            lock (SpotSet.Lock) {
                outputStream = new byte[MESSAGE_PREAMBLE.Length + (SpotSet.Spots.Length * COLORS_PER_LED)];
                Buffer.BlockCopy(MESSAGE_PREAMBLE, 0, outputStream, 0, MESSAGE_PREAMBLE.Length);
                foreach (Spot spot in SpotSet.Spots) {
                    outputStream[counter++] = spot.Brush.Color.B;
                    outputStream[counter++] = spot.Brush.Color.G;
                    outputStream[counter++] = spot.Brush.Color.R;
                }
            }
            return outputStream;
        }

        public void Start() {
            if (!backgroundWorker.IsBusy)
                backgroundWorker.RunWorkerAsync();
        }
        public void Stop() {
            if (backgroundWorker.IsBusy)
                backgroundWorker.CancelAsync();
        }
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing) {
            if (disposing)
                Stop();
        }
    }
}
