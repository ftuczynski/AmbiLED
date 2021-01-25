using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace AmbiLED {
    public partial class MainForm : Form {

        ScreenCapture screenCapture;
        SerialStream serialStream;
        Overlay overlay;

        public MainForm() {
            InitializeComponent();
            RefreshFields();
            InitializeFieldLimits();
        }

        private void InitializeFieldLimits() {
            numericUpDownSpotsX.Minimum = 2;
            numericUpDownSpotsX.Maximum = 100;

            numericUpDownSpotsY.Minimum = 2;
            numericUpDownSpotsY.Maximum = 100;

            numericUpDownSpotWidth.Minimum = 10;
            numericUpDownSpotWidth.Maximum = Program.ScreenWidth;

            numericUpDownSpotHeight.Minimum = 10;
            numericUpDownSpotHeight.Maximum = Program.ScreenHeight;

            numericUpDownBorderX.Minimum = 0;
            numericUpDownBorderX.Maximum = Program.ScreenWidth / 4;

            numericUpDownBorderY.Minimum = 0;
            numericUpDownBorderY.Maximum = Program.ScreenHeight / 4;

            numericUpDownOffsetX.Minimum = -Program.ScreenWidth / 2;
            numericUpDownOffsetX.Maximum = Program.ScreenWidth / 2;

            numericUpDownOffsetY.Minimum = -Program.ScreenHeight / 2;
            numericUpDownOffsetY.Maximum = Program.ScreenHeight / 2;
        }

        private void RefreshFields() {
            numericUpDownSpotsX.Value = Settings.SpotsX;
            numericUpDownSpotsY.Value = Settings.SpotsY;
            numericUpDownSpotWidth.Value = Settings.SpotWidth;
            numericUpDownSpotHeight.Value = Settings.SpotHeight;
            numericUpDownBorderX.Value = Settings.BorderX;
            numericUpDownBorderY.Value = Settings.BorderY;
            numericUpDownOffsetX.Value = Settings.OffsetX;
            numericUpDownOffsetY.Value = Settings.OffsetY;
            checkBoxMirrorX.Checked = Settings.MirrorX;
            checkBoxMirrorY.Checked = Settings.MirrorY;
            checkBoxAutostart.Checked = Settings.Autostart;
            checkBoxStartMin.Checked = Settings.StartMinimized;
            checkBoxOverlay.Checked = Settings.OverlayActive;
            groupBoxSpots.Text = $"Spots ({2 * (Settings.SpotsX + Settings.SpotsY) - 4} LEDs)";
            if (Settings.OutputActive)
                buttonStart.Text = "Stop";
            else
                buttonStart.Text = "Start";
            RefreshComPorts();

        }

        private void RefreshComPorts() {
            comboBoxComPort.Text = Settings.ComPort;
            comboBoxComPort.Items.Clear();
            foreach (string x in SerialPort.GetPortNames())
                comboBoxComPort.Items.Add(x);
            if (comboBoxComPort.Text.Equals("") && comboBoxComPort.Items.Count > 0)
                comboBoxComPort.Text = (string)comboBoxComPort.Items[0];
                
        }
        private void RefreshOverlayGraphics() {
            if (overlay != null)
                overlay.RefreshGraphics();
        }

        private void RefreshOverlay() {
            if (overlay == null)
                overlay = new Overlay();
            if (Settings.OverlayActive) {
                TopMost = true;
                overlay.Start();
            }
            else {
                overlay.Stop();
                overlay = null;
                TopMost = false;
            }
        }

        private void RefreshCapturing() {
            if (screenCapture == null)
                screenCapture = new ScreenCapture();
            if (Settings.OutputActive || Settings.OverlayActive) {
                screenCapture.Start();
            }
            else {
                screenCapture.Stop();
                screenCapture = null;
            }
        }

        private void RefreshTransfer() {
            if (serialStream == null)
                serialStream = new SerialStream();
            if (Settings.OutputActive) {
                comboBoxComPort.Enabled = false;
                serialStream.Start();
            }
            else {
                serialStream.Stop();
                serialStream = null;
                comboBoxComPort.Enabled = true;
            }
        }

        private void RefreshAll() {
            SpotSet.Refresh();
            RefreshFields();
            RefreshOverlayGraphics();
        }

        private void numericUpDownSpotsX_ValueChanged(object sender, EventArgs e) {
            Settings.SpotsX = (int)numericUpDownSpotsX.Value;
            RefreshAll();
        }

        private void numericUpDownSpotsY_ValueChanged(object sender, EventArgs e) {
            Settings.SpotsY = (int)numericUpDownSpotsY.Value;
            RefreshAll();
        }

        private void numericUpDownSpotWidth_ValueChanged(object sender, EventArgs e) {
            Settings.SpotWidth = (int)numericUpDownSpotWidth.Value;
            RefreshAll();
        }

        private void numericUpDownSpotHeight_ValueChanged(object sender, EventArgs e) {
            Settings.SpotHeight = (int)numericUpDownSpotHeight.Value;
            RefreshAll();
        }

        private void numericUpDownBorderX_ValueChanged(object sender, EventArgs e) {
            Settings.BorderX = (int)numericUpDownBorderX.Value;
            RefreshAll();
        }

        private void numericUpDownBorderY_ValueChanged(object sender, EventArgs e) {
            Settings.BorderY = (int)numericUpDownBorderY.Value;
            RefreshAll();
        }

        private void numericUpDownOffsetX_ValueChanged(object sender, EventArgs e) {
            Settings.OffsetX = (int)numericUpDownOffsetX.Value;
            RefreshAll();
        }

        private void numericUpDownOffsetY_ValueChanged(object sender, EventArgs e) {
            Settings.OffsetY = (int)numericUpDownOffsetY.Value;
            RefreshAll();
        }

        private void buttonStart_Click(object sender, EventArgs e) {
            Settings.OutputActive = !Settings.OutputActive;
            RefreshAll();
            RefreshCapturing();
            RefreshTransfer();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            RefreshCapturing();
            RefreshTransfer();
            if (Settings.StartMinimized)
                WindowState = FormWindowState.Minimized;
        }

        private void checkBoxMirrorX_CheckedChanged(object sender, EventArgs e) {
            Settings.MirrorX = checkBoxMirrorX.Checked;
            RefreshAll();
        }

        private void checkBoxMirrorY_CheckedChanged(object sender, EventArgs e) {
            Settings.MirrorY = checkBoxMirrorY.Checked;
            RefreshAll();
        }

        private void checkBoxAutostart_CheckedChanged(object sender, EventArgs e) {
            Settings.Autostart = checkBoxAutostart.Checked;
            if (Settings.Autostart)
                Autostart.Add();
            else
                Autostart.Remove();
            RefreshAll();
        }

        private void checkBoxStartMin_CheckedChanged(object sender, EventArgs e) {
            Settings.StartMinimized = checkBoxStartMin.Checked;
            RefreshAll();
        }

        private void checkBoxOverlay_CheckedChanged(object sender, EventArgs e) {
            Settings.OverlayActive = checkBoxOverlay.Checked;
            RefreshAll();

            RefreshCapturing();
            RefreshOverlay();
        }

        private void comboBoxComPort_SelectedIndexChanged(object sender, EventArgs e) {
            Settings.ComPort = comboBoxComPort.Text;
            RefreshAll();
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) {
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void MainForm_Resize(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Normal) {
                notifyIcon1.Visible = false;
            }
            else if (WindowState == FormWindowState.Minimized) {
                notifyIcon1.Visible = true;
                ShowInTaskbar = false;
            }
        }
    }
}
