using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbiLED {
    class PointDx {
        public int X { get; set; }
        public int Y { get; set; }
        public long PosDx { get; set; }

        public PointDx(int x, int y) {
            X = x;
            Y = y;
            PosDx = getPos(x, y);
        }
        private static long getPos(int x, int y) {
            return y * Program.ScreenWidth + x;
        }
    }
}
