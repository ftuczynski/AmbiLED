using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            
            
        }
    }
}
