using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmbiLED {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void numericUpDownSpotsX_ValueChanged(object sender, EventArgs e) {
            Settings.SpotsX = (int)numericUpDownSpotsX.Value;
        }

        private void numericUpDownSpotsY_ValueChanged(object sender, EventArgs e) {
            Settings.SpotsY = (int)numericUpDownSpotsY.Value;
        }

        private void numericUpDownSpotWidth_ValueChanged(object sender, EventArgs e) {
            Settings.SpotWidth = (int)numericUpDownSpotWidth.Value;
        }

        private void numericUpDownSpotHeight_ValueChanged(object sender, EventArgs e) {
            Settings.SpotHeight = (int)numericUpDownSpotHeight.Value;
        }

        private void numericUpDownBorderX_ValueChanged(object sender, EventArgs e) {
            Settings.BorderX = (int)numericUpDownBorderX.Value;
        }

        private void numericUpDownBorderY_ValueChanged(object sender, EventArgs e) {
            Settings.BorderY = (int)numericUpDownBorderY.Value;
        }

        private void numericUpDownOffsetX_ValueChanged(object sender, EventArgs e) {
            Settings.OffsetX = (int)numericUpDownOffsetX.Value;
        }

        private void numericUpDownOffsetY_ValueChanged(object sender, EventArgs e) {
            Settings.OffsetY = (int)numericUpDownOffsetY.Value;
        }
    }
}
