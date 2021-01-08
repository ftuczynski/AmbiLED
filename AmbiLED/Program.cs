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

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            
            
        }
    }
}
