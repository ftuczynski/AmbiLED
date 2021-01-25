using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AmbiLED {
    public partial class Overlay : Form {

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll", SetLastError = true)]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_TRANSPARENT = 0x20;

        //Arrows
        private Point topHead;
        private Point topEnd;
        private Point rightHead;
        private Point rightEnd;
        private Point bottomHead;
        private Point bottomEnd;
        private Point leftHead;
        private Point leftEnd;

        private Graphics graphics;
        private readonly object graphicsLock = new object();
        private BackgroundWorker backgroundWorker = new BackgroundWorker();

        public Overlay() {
            InitializeComponent();
            ShowInTaskbar = false;

            InitializeArrowPoints();
            int exStyle = GetWindowLong(this.Handle, GWL_EXSTYLE);
            exStyle |= WS_EX_TRANSPARENT;
            SetWindowLong(this.Handle, GWL_EXSTYLE, exStyle);

            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_Completed;
            backgroundWorker.WorkerSupportsCancellation = true;
        }

        private void InitializeArrowPoints() {
            topHead = new Point(4 * (Program.ScreenWidth / 5), 1 * (Program.ScreenHeight / 5));
            topEnd = new Point(1 * (Program.ScreenWidth / 5), 1 * (Program.ScreenHeight / 5));

            rightHead = new Point(6 * (Program.ScreenWidth / 7), 4 * (Program.ScreenHeight / 5));
            rightEnd = new Point(6 * (Program.ScreenWidth / 7), 1 * (Program.ScreenHeight / 5));

            bottomHead = new Point(1 * (Program.ScreenWidth / 5), 4 * (Program.ScreenHeight / 5));
            bottomEnd = new Point(4 * (Program.ScreenWidth / 5), 4 * (Program.ScreenHeight / 5));

            leftHead = new Point(1 * (Program.ScreenWidth / 7), 1 * (Program.ScreenHeight / 5));
            leftEnd = new Point(1 * (Program.ScreenWidth / 7), 4 * (Program.ScreenHeight / 5));
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
            AdjustableArrowCap arrowCap = new AdjustableArrowCap(5, 5);
            Pen arrowPen = new Pen(Color.Black, 5);
            arrowPen.Alignment = PenAlignment.Inset;
            arrowPen.DashStyle = DashStyle.DashDotDot;
            arrowPen.CustomEndCap = arrowCap;

            Pen spotBorderPen = new Pen(Color.Black, 2);
            Font font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold);
            SolidBrush solidBrush = new SolidBrush(Color.Black);

            while (!backgroundWorker.CancellationPending) {
                lock (graphicsLock) {
                    try {
                        graphics = CreateGraphics();
                        if (Settings.SpotsX > 1 && Settings.SpotsY > 1) {
                            if ((Settings.MirrorX && Settings.MirrorY) || (!Settings.MirrorX && !Settings.MirrorY)) {
                                graphics.DrawLine(arrowPen, topEnd, topHead);
                                graphics.DrawLine(arrowPen, rightEnd, rightHead);
                                graphics.DrawLine(arrowPen, bottomEnd, bottomHead);
                                graphics.DrawLine(arrowPen, leftEnd, leftHead);
                            }
                            else {
                                graphics.DrawLine(arrowPen, topHead, topEnd);
                                graphics.DrawLine(arrowPen, rightHead, rightEnd);
                                graphics.DrawLine(arrowPen, bottomHead, bottomEnd);
                                graphics.DrawLine(arrowPen, leftHead, leftEnd);
                            }
                        }
                        lock (SpotSet.Lock) {
                            foreach (Spot spot in SpotSet.Spots) {
                                graphics.DrawRectangle(spotBorderPen, spot.RectangleBorder);
                                graphics.FillRectangle(spot.Brush, spot.RectangleFilling);

                                //TODO - better placement of first led
                                if (spot == SpotSet.Spots[0])
                                    graphics.DrawString("1", font, solidBrush, spot.TopLeft.X, spot.TopLeft.Y);
                            }
                        }
                    }
                    catch (Exception ex) {
                        Console.Write(ex);
                    }
                }
            }

        }

        private void BackgroundWorker_Completed(object sender, RunWorkerCompletedEventArgs e) {
            Close();
        }

        public void RefreshGraphics() {
            try {
                lock (graphicsLock) {
                    if (graphics != null)
                        graphics.Clear(BackColor);
                }
            }
            catch (Exception ex) {
                Console.Write(ex);
            }
        }

        public void Start() {
            Show();
            if (!backgroundWorker.IsBusy)
                backgroundWorker.RunWorkerAsync();
        }

        public void Stop() {
            if (backgroundWorker.IsBusy)
                backgroundWorker.CancelAsync();
        }
    }
}
