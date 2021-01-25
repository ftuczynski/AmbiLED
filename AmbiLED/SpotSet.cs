namespace AmbiLED {
    class SpotSet {
        public static Spot[] Spots { get; set; }
        public static readonly object Lock = new object();

        public static int CountSpots(int x, int y) {
            int i = x * y;
            return (x > 2 && y > 2) ? i - ((x - 2) * (y - 2)) : i;
        }

        public static void Refresh() {
            lock (Lock) {
                Spots = new Spot[CountSpots(Settings.SpotsX, Settings.SpotsY)];

                int canvasWidth = Program.ScreenWidth - 2 * Settings.BorderX;
                int canvasHeight = Program.ScreenHeight - 2 * Settings.BorderY;

                int xResolution = Settings.SpotsX > 1 ? (canvasWidth - Settings.SpotWidth) / (Settings.SpotsX - 1) : 0;
                int yResolution = Settings.SpotsY > 1 ? (canvasHeight - Settings.SpotHeight) / (Settings.SpotsY - 1) : 0;
                int xRemainingOffset = Settings.SpotsX > 1 ? ((canvasWidth - Settings.SpotWidth) % (Settings.SpotsX - 1)) / 2 : 0;
                int yRemainingOffset = Settings.SpotsY > 1 ? ((canvasHeight - Settings.SpotHeight) % (Settings.SpotsY - 1)) / 2 : 0;

                int x, y;
                int counter = 0;
                int relIndex = Settings.SpotsX - Settings.SpotsY + 1;

                for (int j = 0; j < Settings.SpotsY; j++) {
                    for (int i = 0; i < Settings.SpotsX; i++) {
                        if ((i == 0) || (j == 0) || (i == Settings.SpotsX - 1) || (j == Settings.SpotsY - 1)) {
                            x = xRemainingOffset = Settings.BorderX + Settings.OffsetX + i * xResolution + Settings.SpotWidth / 2;
                            y = yRemainingOffset = Settings.BorderY + Settings.OffsetY + j * yResolution + Settings.SpotHeight / 2;

                            int index = counter++;

                            if(Settings.SpotsX > 1 && Settings.SpotsY > 1) {
                                if (j != 0 && j != Settings.SpotsY - 1) {
                                    if (i == 0) {
                                        index += relIndex + ((Settings.SpotsY - 1 - j) * 3);
                                    }else if (i == Settings.SpotsX - 1) {
                                        index -= j;
                                    }
                                }
                                if(j!=0 && j == Settings.SpotsY - 1) {
                                    index += relIndex - (i * 2);
                                }
                            }
                            SpotSet.Spots[index] = new Spot(x, y, Settings.SpotWidth, Settings.SpotHeight);
                        }
                    }
                }
                if (Settings.SpotsY > 1 && Settings.MirrorX)
                    mirrorX();
                if (Settings.SpotsX > 1 && Settings.MirrorY)
                    mirrorY();

            }
        }

        private static void swap(int index1, int index2) {
            Spot temp = Spots[index1];
            Spots[index1] = Spots[index2];
            Spots[index2] = temp;
        }

        private static void mirror(int startIndex, int length) {
            int half = length / 2;
            int end = startIndex + length - 1;
            for(int i=0; i < half; i++) {
                swap(startIndex + i, end - i);
            }
        }

        private static void mirrorX() {
            for (int i = 0; i < Settings.SpotsX; i++) {
                int index1 = i;
                int index2 = (Spots.Length - 1) - (Settings.SpotsY - 2) - i;
                swap(index1, index2);
            }

            mirror(Settings.SpotsX, Settings.SpotsY - 2);

            if (Settings.SpotsX > 1)
                mirror(2 * Settings.SpotsX + Settings.SpotsY - 2, Settings.SpotsY - 2);
        }

        private static void mirrorY() {
            for (int i = 0; i < Settings.SpotsY - 2; i++) {
                int index1 = Settings.SpotsX + i;
                int index2 = (Spots.Length - 1) - i;
                swap(index1, index2);
            }

            mirror(0, Settings.SpotsX);

            if (Settings.SpotsY > 1)
                mirror(Settings.SpotsX + Settings.SpotsY - 2, Settings.SpotsX);
        }
        
    }
}
