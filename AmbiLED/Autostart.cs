using Microsoft.Win32;
using System.Windows.Forms;

namespace AmbiLED {
    static class Autostart {
        private static RegistryKey autostartKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        private static bool IsStartupItem() {
            return autostartKey.GetValue("AmbiLED") != null;
        }

        public static void Add() {
            if (!IsStartupItem())
                autostartKey.SetValue("AmbiLED", Application.ExecutablePath.ToString());
        }

        public static void Remove() {
            if (IsStartupItem())
                autostartKey.DeleteValue("AmbiLED", false);
        }
    }
}
