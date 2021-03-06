﻿namespace AmbiLED {
    static class Settings {

        private static int spotsX;
        private static int spotsY;
        private static int spotWidth;
        private static int spotHeight;
        private static int borderX;
        private static int borderY;
        private static int offsetX;
        private static int offsetY;
        private static bool mirrorX;
        private static bool mirrorY;
        private static string comPort;
        private static bool autostart;
        private static bool startMinimized;
        private static bool overlayActive;
        private static bool outputActive;

        public static void Refresh() {
            spotsX = Properties.Settings.Default.SPOTS_X;
            spotsY = Properties.Settings.Default.SPOTS_Y;
            spotWidth = Properties.Settings.Default.SPOT_WIDTH;
            spotHeight = Properties.Settings.Default.SPOT_HEIGHT;
            borderX = Properties.Settings.Default.BORDER_X;
            borderY = Properties.Settings.Default.BORDER_Y;
            offsetX = Properties.Settings.Default.OFFSET_X;
            offsetY = Properties.Settings.Default.OFFSET_Y;
            mirrorX = Properties.Settings.Default.MIRROR_X;
            mirrorY = Properties.Settings.Default.MIRROR_Y;
            comPort = Properties.Settings.Default.COM_PORT;
            autostart = Properties.Settings.Default.AUTOSTART;
            startMinimized = Properties.Settings.Default.START_MINIMIZED;
            overlayActive = Properties.Settings.Default.OVERLAY_ACTIVE;
            outputActive = Properties.Settings.Default.OUTPUT_ACTIVE;
        }
        public static int SpotsX {
            get {
                return spotsX;
            }
            set {
                spotsX = value;
                Properties.Settings.Default.SPOTS_X = value;
                Properties.Settings.Default.Save();
            }
        }
        public static int SpotsY {
            get {
                return spotsY;
            }
            set {
                spotsY = value;
                Properties.Settings.Default.SPOTS_Y = value;
                Properties.Settings.Default.Save();
            }
        }
        public static int SpotWidth {
            get {
                return spotWidth;
            }
            set {
                spotWidth = value;
                Properties.Settings.Default.SPOT_WIDTH = value;
                Properties.Settings.Default.Save();
            }
        }
        public static int SpotHeight {
            get {
                return spotHeight;
            }
            set {
                spotHeight = value;
                Properties.Settings.Default.SPOT_HEIGHT = value;
                Properties.Settings.Default.Save();
            }
        }
        public static int BorderX {
            get {
                return borderX;
            }
            set {
                borderX = value;
                Properties.Settings.Default.BORDER_X = value;
                Properties.Settings.Default.Save();
            }
        }
        public static int BorderY {
            get {
                return borderY;
            }
            set {
                borderY = value;
                Properties.Settings.Default.BORDER_Y = value;
                Properties.Settings.Default.Save();
            }
        }
        public static int OffsetX {
            get {
                return offsetX;
            }
            set {
                offsetX = value;
                Properties.Settings.Default.OFFSET_X = value;
                Properties.Settings.Default.Save();
            }
        }
        public static int OffsetY {
            get {
                return offsetY;
            }
            set {
                offsetY = value;
                Properties.Settings.Default.OFFSET_Y = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool MirrorX {
            get {
                return mirrorX;
            }
            set {
                mirrorX = value;
                Properties.Settings.Default.MIRROR_X = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool MirrorY {
            get {
                return mirrorY;
            }
            set {
                mirrorY = value;
                Properties.Settings.Default.MIRROR_Y = value;
                Properties.Settings.Default.Save();
            }
        }
        public static string ComPort {
            get {
                return comPort;
            }
            set {
                comPort = value;
                Properties.Settings.Default.COM_PORT = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool Autostart {
            get {
                return autostart;
            }
            set {
                autostart = value;
                Properties.Settings.Default.AUTOSTART = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool StartMinimized {
            get {
                return startMinimized;
            }
            set {
                startMinimized = value;
                Properties.Settings.Default.START_MINIMIZED = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool OverlayActive {
            get {
                return overlayActive;
            }
            set {
                overlayActive = value;
                Properties.Settings.Default.OVERLAY_ACTIVE = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool OutputActive {
            get {
                return outputActive;
            }
            set {
                outputActive = value;
                Properties.Settings.Default.OUTPUT_ACTIVE = value;
                Properties.Settings.Default.Save();
            }
        }
    }
}
