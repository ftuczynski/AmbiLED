using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbiLED {
    class PointDx {
        public int X { get; private set; }
        public int Y { get; private set; }
        public long PosDx { get; private set; }

        public PointDx(int x, int y) {
            X = x;
            Y = y;
            PosDx = GetPos(x, y);
        }
        private static long GetPos(int x, int y) {
            long pos = y * Program.ScreenWidth + x;
            return (pos <= Program.ScreenPixels) ? (pos * 4) : -1;
        }
    }
}
