using System;
using System.Drawing;

namespace AmbiLED {
    class Spot : IDisposable {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public PointDx Center { get; private set; }
        public PointDx TopLeft { get; private set; }
        public PointDx TopRight { get; private set; }
        public PointDx BottomLeft { get; private set; }
        public PointDx BottomRight { get; private set; }

        public Rectangle Rectangle { get; private set; }
        public Rectangle RectangleBorder { get; private set; }
        public Rectangle RectangleFilling { get; private set; }

        public SolidBrush Brush { get; private set; }

        public Spot(int centerX, int centerY, int width, int height) {
            Center = new PointDx(centerX, centerY);
            Width = width;
            Height = height;

            int distanceX = width / 2;
            int distanceY = height / 2;
            TopLeft = new PointDx(Center.X - distanceX, Center.Y - distanceY);
            TopRight = new PointDx(Center.X + distanceX, Center.Y - distanceY);
            BottomLeft = new PointDx(Center.X - distanceX, Center.Y + distanceY);
            BottomRight = new PointDx(Center.X + distanceX, Center.Y + distanceY);

            Rectangle = new Rectangle(TopLeft.X, TopLeft.Y, Width, Height);
            RectangleBorder = new Rectangle(TopLeft.X + 2, TopLeft.Y + 2, Width - 4, Height - 4);
            RectangleFilling = new Rectangle(TopLeft.X + 4, TopLeft.Y + 4, Width - 8, Height - 8);

            Brush = new SolidBrush(Color.Black);
        }

        public void SetColor(int r, int g, int b) {
            Brush.Color = Color.FromArgb(r, g, b);
        }

        public void Dispose() {
            Brush.Dispose();
        }
    }
}
