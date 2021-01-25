
namespace AmbiLED {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                if(screenCapture!=null)
                    screenCapture.Dispose();
                if(serialStream!=null)
                    serialStream.Dispose();
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownOffsetY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOffsetX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBorderY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBorderX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpotHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpotWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpotsY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpotsX = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.checkBoxOverlay = new System.Windows.Forms.CheckBox();
            this.checkBoxStartMin = new System.Windows.Forms.CheckBox();
            this.checkBoxAutostart = new System.Windows.Forms.CheckBox();
            this.checkBoxMirrorY = new System.Windows.Forms.CheckBox();
            this.checkBoxMirrorX = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBorderY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBorderX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpotHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpotWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpotsY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpotsX)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownOffsetY);
            this.groupBox1.Controls.Add(this.numericUpDownOffsetX);
            this.groupBox1.Controls.Add(this.numericUpDownBorderY);
            this.groupBox1.Controls.Add(this.numericUpDownBorderX);
            this.groupBox1.Controls.Add(this.numericUpDownSpotHeight);
            this.groupBox1.Controls.Add(this.numericUpDownSpotWidth);
            this.groupBox1.Controls.Add(this.numericUpDownSpotsY);
            this.groupBox1.Controls.Add(this.numericUpDownSpotsX);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spots";
            // 
            // numericUpDownOffsetY
            // 
            this.numericUpDownOffsetY.Location = new System.Drawing.Point(79, 204);
            this.numericUpDownOffsetY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownOffsetY.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.numericUpDownOffsetY.Name = "numericUpDownOffsetY";
            this.numericUpDownOffsetY.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownOffsetY.TabIndex = 15;
            this.numericUpDownOffsetY.ValueChanged += new System.EventHandler(this.numericUpDownOffsetY_ValueChanged);
            // 
            // numericUpDownOffsetX
            // 
            this.numericUpDownOffsetX.Location = new System.Drawing.Point(79, 177);
            this.numericUpDownOffsetX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownOffsetX.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.numericUpDownOffsetX.Name = "numericUpDownOffsetX";
            this.numericUpDownOffsetX.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownOffsetX.TabIndex = 14;
            this.numericUpDownOffsetX.ValueChanged += new System.EventHandler(this.numericUpDownOffsetX_ValueChanged);
            // 
            // numericUpDownBorderY
            // 
            this.numericUpDownBorderY.Location = new System.Drawing.Point(79, 150);
            this.numericUpDownBorderY.Name = "numericUpDownBorderY";
            this.numericUpDownBorderY.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownBorderY.TabIndex = 13;
            this.numericUpDownBorderY.ValueChanged += new System.EventHandler(this.numericUpDownBorderY_ValueChanged);
            // 
            // numericUpDownBorderX
            // 
            this.numericUpDownBorderX.Location = new System.Drawing.Point(79, 123);
            this.numericUpDownBorderX.Name = "numericUpDownBorderX";
            this.numericUpDownBorderX.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownBorderX.TabIndex = 12;
            this.numericUpDownBorderX.ValueChanged += new System.EventHandler(this.numericUpDownBorderX_ValueChanged);
            // 
            // numericUpDownSpotHeight
            // 
            this.numericUpDownSpotHeight.Location = new System.Drawing.Point(79, 97);
            this.numericUpDownSpotHeight.Name = "numericUpDownSpotHeight";
            this.numericUpDownSpotHeight.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownSpotHeight.TabIndex = 11;
            this.numericUpDownSpotHeight.ValueChanged += new System.EventHandler(this.numericUpDownSpotHeight_ValueChanged);
            // 
            // numericUpDownSpotWidth
            // 
            this.numericUpDownSpotWidth.Location = new System.Drawing.Point(79, 71);
            this.numericUpDownSpotWidth.Name = "numericUpDownSpotWidth";
            this.numericUpDownSpotWidth.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownSpotWidth.TabIndex = 10;
            this.numericUpDownSpotWidth.ValueChanged += new System.EventHandler(this.numericUpDownSpotWidth_ValueChanged);
            // 
            // numericUpDownSpotsY
            // 
            this.numericUpDownSpotsY.Location = new System.Drawing.Point(79, 45);
            this.numericUpDownSpotsY.Name = "numericUpDownSpotsY";
            this.numericUpDownSpotsY.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownSpotsY.TabIndex = 9;
            this.numericUpDownSpotsY.ValueChanged += new System.EventHandler(this.numericUpDownSpotsY_ValueChanged);
            // 
            // numericUpDownSpotsX
            // 
            this.numericUpDownSpotsX.Location = new System.Drawing.Point(79, 19);
            this.numericUpDownSpotsX.Name = "numericUpDownSpotsX";
            this.numericUpDownSpotsX.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownSpotsX.TabIndex = 8;
            this.numericUpDownSpotsX.ValueChanged += new System.EventHandler(this.numericUpDownSpotsX_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Offset Y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Offset X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Border Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Border X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Spot Height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Spot Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Spots Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spots X:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxComPort);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(168, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial";
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(69, 17);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(127, 21);
            this.comboBoxComPort.TabIndex = 1;
            this.comboBoxComPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxComPort_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "COM Port:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonStart);
            this.groupBox3.Controls.Add(this.checkBoxOverlay);
            this.groupBox3.Controls.Add(this.checkBoxStartMin);
            this.groupBox3.Controls.Add(this.checkBoxAutostart);
            this.groupBox3.Controls.Add(this.checkBoxMirrorY);
            this.groupBox3.Controls.Add(this.checkBoxMirrorX);
            this.groupBox3.Location = new System.Drawing.Point(169, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 170);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controls";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(7, 141);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(188, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // checkBoxOverlay
            // 
            this.checkBoxOverlay.AutoSize = true;
            this.checkBoxOverlay.Location = new System.Drawing.Point(7, 116);
            this.checkBoxOverlay.Name = "checkBoxOverlay";
            this.checkBoxOverlay.Size = new System.Drawing.Size(62, 17);
            this.checkBoxOverlay.TabIndex = 4;
            this.checkBoxOverlay.Text = "Overlay";
            this.checkBoxOverlay.UseVisualStyleBackColor = true;
            this.checkBoxOverlay.CheckedChanged += new System.EventHandler(this.checkBoxOverlay_CheckedChanged);
            // 
            // checkBoxStartMin
            // 
            this.checkBoxStartMin.AutoSize = true;
            this.checkBoxStartMin.Location = new System.Drawing.Point(7, 92);
            this.checkBoxStartMin.Name = "checkBoxStartMin";
            this.checkBoxStartMin.Size = new System.Drawing.Size(97, 17);
            this.checkBoxStartMin.TabIndex = 3;
            this.checkBoxStartMin.Text = "Start Minimized";
            this.checkBoxStartMin.UseVisualStyleBackColor = true;
            this.checkBoxStartMin.CheckedChanged += new System.EventHandler(this.checkBoxStartMin_CheckedChanged);
            // 
            // checkBoxAutostart
            // 
            this.checkBoxAutostart.AutoSize = true;
            this.checkBoxAutostart.Location = new System.Drawing.Point(7, 68);
            this.checkBoxAutostart.Name = "checkBoxAutostart";
            this.checkBoxAutostart.Size = new System.Drawing.Size(68, 17);
            this.checkBoxAutostart.TabIndex = 2;
            this.checkBoxAutostart.Text = "Autostart";
            this.checkBoxAutostart.UseVisualStyleBackColor = true;
            this.checkBoxAutostart.CheckedChanged += new System.EventHandler(this.checkBoxAutostart_CheckedChanged);
            // 
            // checkBoxMirrorY
            // 
            this.checkBoxMirrorY.AutoSize = true;
            this.checkBoxMirrorY.Location = new System.Drawing.Point(7, 44);
            this.checkBoxMirrorY.Name = "checkBoxMirrorY";
            this.checkBoxMirrorY.Size = new System.Drawing.Size(84, 17);
            this.checkBoxMirrorY.TabIndex = 1;
            this.checkBoxMirrorY.Text = "Mirror Y-Axis";
            this.checkBoxMirrorY.UseVisualStyleBackColor = true;
            this.checkBoxMirrorY.CheckedChanged += new System.EventHandler(this.checkBoxMirrorY_CheckedChanged);
            // 
            // checkBoxMirrorX
            // 
            this.checkBoxMirrorX.AutoSize = true;
            this.checkBoxMirrorX.Location = new System.Drawing.Point(7, 20);
            this.checkBoxMirrorX.Name = "checkBoxMirrorX";
            this.checkBoxMirrorX.Size = new System.Drawing.Size(84, 17);
            this.checkBoxMirrorX.TabIndex = 0;
            this.checkBoxMirrorX.Text = "Mirror X-Axis";
            this.checkBoxMirrorX.UseVisualStyleBackColor = true;
            this.checkBoxMirrorX.CheckedChanged += new System.EventHandler(this.checkBoxMirrorX_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AmbiLED";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(94, 26);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(93, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 256);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 295);
            this.MinimumSize = new System.Drawing.Size(394, 295);
            this.Name = "MainForm";
            this.Text = "AmbiLED";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBorderY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBorderX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpotHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpotWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpotsY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpotsX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownOffsetY;
        private System.Windows.Forms.NumericUpDown numericUpDownOffsetX;
        private System.Windows.Forms.NumericUpDown numericUpDownBorderY;
        private System.Windows.Forms.NumericUpDown numericUpDownBorderX;
        private System.Windows.Forms.NumericUpDown numericUpDownSpotHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownSpotWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownSpotsY;
        private System.Windows.Forms.NumericUpDown numericUpDownSpotsX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.CheckBox checkBoxOverlay;
        private System.Windows.Forms.CheckBox checkBoxStartMin;
        private System.Windows.Forms.CheckBox checkBoxAutostart;
        private System.Windows.Forms.CheckBox checkBoxMirrorY;
        private System.Windows.Forms.CheckBox checkBoxMirrorX;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
    }
}

