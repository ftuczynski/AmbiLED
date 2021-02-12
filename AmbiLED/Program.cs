using System;
using System.Windows.Forms;

namespace AmbiLED {
    static class Program {
        public static int ScreenWidth {
            get {
                return Screen.PrimaryScreen.Bounds.Width;
            }
        }
        public static int ScreenHeight {
            get {
                return Screen.PrimaryScreen.Bounds.Height;
            }
        }
        public static int ScreenPixels {
            get {
                return ScreenWidth * ScreenHeight;
            }
        }

        [STAThread]
        static void Main() {
            Settings.Refresh();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
