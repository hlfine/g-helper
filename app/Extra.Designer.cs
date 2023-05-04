﻿using CustomControls;
using GHelper.Properties;

namespace GHelper
{
    partial class Extra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBindings = new GroupBox();
            pictureHelp = new PictureBox();
            textFNF4 = new TextBox();
            comboFNF4 = new RComboBox();
            labelFNF4 = new Label();
            textM4 = new TextBox();
            textM3 = new TextBox();
            comboM4 = new RComboBox();
            labelM4 = new Label();
            comboM3 = new RComboBox();
            labelM3 = new Label();
            groupLight = new GroupBox();
            labelBrightness = new Label();
            trackBrightness = new TrackBar();
            labelSpeed = new Label();
            comboKeyboardSpeed = new RComboBox();
            checkShutdown = new CheckBox();
            checkSleep = new CheckBox();
            checkBoot = new CheckBox();
            checkAwake = new CheckBox();
            groupOther = new GroupBox();
            checkUSBC = new CheckBox();
            checkNoOverdrive = new CheckBox();
            checkKeyboardAuto = new CheckBox();
            checkTopmost = new CheckBox();
            groupBindings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHelp).BeginInit();
            groupLight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBrightness).BeginInit();
            groupOther.SuspendLayout();
            SuspendLayout();
            // 
            // groupBindings
            // 
            groupBindings.Controls.Add(pictureHelp);
            groupBindings.Controls.Add(textFNF4);
            groupBindings.Controls.Add(comboFNF4);
            groupBindings.Controls.Add(labelFNF4);
            groupBindings.Controls.Add(textM4);
            groupBindings.Controls.Add(textM3);
            groupBindings.Controls.Add(comboM4);
            groupBindings.Controls.Add(labelM4);
            groupBindings.Controls.Add(comboM3);
            groupBindings.Controls.Add(labelM3);
            groupBindings.Dock = DockStyle.Top;
            groupBindings.Location = new Point(10, 10);
            groupBindings.Name = "groupBindings";
            groupBindings.Size = new Size(844, 242);
            groupBindings.TabIndex = 0;
            groupBindings.TabStop = false;
            groupBindings.Text = "Key Bindings";
            // 
            // pictureHelp
            // 
            pictureHelp.BackgroundImage = Resources.icons8_help_64;
            pictureHelp.BackgroundImageLayout = ImageLayout.Zoom;
            pictureHelp.Cursor = Cursors.Hand;
            pictureHelp.Location = new Point(744, 57);
            pictureHelp.Name = "pictureHelp";
            pictureHelp.Size = new Size(32, 32);
            pictureHelp.TabIndex = 9;
            pictureHelp.TabStop = false;
            // 
            // textFNF4
            // 
            textFNF4.Location = new Point(415, 176);
            textFNF4.Name = "textFNF4";
            textFNF4.PlaceholderText = "action";
            textFNF4.Size = new Size(320, 39);
            textFNF4.TabIndex = 8;
            // 
            // comboFNF4
            // 
            comboFNF4.BorderColor = Color.White;
            comboFNF4.ButtonColor = Color.FromArgb(255, 255, 255);
            comboFNF4.FormattingEnabled = true;
            comboFNF4.Location = new Point(93, 175);
            comboFNF4.Name = "comboFNF4";
            comboFNF4.Size = new Size(312, 40);
            comboFNF4.TabIndex = 7;
            // 
            // labelFNF4
            // 
            labelFNF4.AutoSize = true;
            labelFNF4.Location = new Point(2, 178);
            labelFNF4.Name = "labelFNF4";
            labelFNF4.Size = new Size(90, 32);
            labelFNF4.TabIndex = 6;
            labelFNF4.Text = "FN+F4:";
            // 
            // textM4
            // 
            textM4.Location = new Point(415, 113);
            textM4.Name = "textM4";
            textM4.PlaceholderText = "action";
            textM4.Size = new Size(320, 39);
            textM4.TabIndex = 5;
            // 
            // textM3
            // 
            textM3.Location = new Point(415, 54);
            textM3.Name = "textM3";
            textM3.PlaceholderText = "notepad /p \"file.txt\"";
            textM3.Size = new Size(320, 39);
            textM3.TabIndex = 4;
            // 
            // comboM4
            // 
            comboM4.BorderColor = Color.White;
            comboM4.ButtonColor = Color.FromArgb(255, 255, 255);
            comboM4.FormattingEnabled = true;
            comboM4.Items.AddRange(new object[] { Strings.PerformanceMode, Strings.OpenGHelper, Strings.Custom });
            comboM4.Location = new Point(93, 112);
            comboM4.Name = "comboM4";
            comboM4.Size = new Size(312, 40);
            comboM4.TabIndex = 3;
            // 
            // labelM4
            // 
            labelM4.AutoSize = true;
            labelM4.Location = new Point(25, 116);
            labelM4.Name = "labelM4";
            labelM4.Size = new Size(54, 32);
            labelM4.TabIndex = 2;
            labelM4.Text = "M4:";
            // 
            // comboM3
            // 
            comboM3.BorderColor = Color.White;
            comboM3.ButtonColor = Color.FromArgb(255, 255, 255);
            comboM3.FormattingEnabled = true;
            comboM3.Items.AddRange(new object[] { Strings.Default, Strings.VolumeMute, Strings.PlayPause, Strings.PrintScreen, Strings.ToggleAura, Strings.Custom });
            comboM3.Location = new Point(93, 54);
            comboM3.Name = "comboM3";
            comboM3.Size = new Size(312, 40);
            comboM3.TabIndex = 1;
            // 
            // labelM3
            // 
            labelM3.AutoSize = true;
            labelM3.Location = new Point(25, 58);
            labelM3.Name = "labelM3";
            labelM3.Size = new Size(54, 32);
            labelM3.TabIndex = 0;
            labelM3.Text = "M3:";
            // 
            // groupLight
            // 
            groupLight.Controls.Add(labelBrightness);
            groupLight.Controls.Add(trackBrightness);
            groupLight.Controls.Add(labelSpeed);
            groupLight.Controls.Add(comboKeyboardSpeed);
            groupLight.Controls.Add(checkShutdown);
            groupLight.Controls.Add(checkSleep);
            groupLight.Controls.Add(checkBoot);
            groupLight.Controls.Add(checkAwake);
            groupLight.Dock = DockStyle.Top;
            groupLight.Location = new Point(10, 252);
            groupLight.Name = "groupLight";
            groupLight.Size = new Size(844, 395);
            groupLight.TabIndex = 1;
            groupLight.TabStop = false;
            groupLight.Text = "Keyboard Backlight";
            // 
            // labelBrightness
            // 
            labelBrightness.Location = new Point(25, 304);
            labelBrightness.Name = "labelBrightness";
            labelBrightness.Size = new Size(197, 49);
            labelBrightness.TabIndex = 0;
            labelBrightness.Text = "Brightness";
            // 
            // trackBrightness
            // 
            trackBrightness.Location = new Point(228, 294);
            trackBrightness.Maximum = 3;
            trackBrightness.Name = "trackBrightness";
            trackBrightness.Size = new Size(600, 90);
            trackBrightness.TabIndex = 1;
            trackBrightness.TickStyle = TickStyle.TopLeft;
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Location = new Point(25, 235);
            labelSpeed.MaximumSize = new Size(200, 0);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(198, 32);
            labelSpeed.TabIndex = 40;
            labelSpeed.Text = "Animation Speed";
            // 
            // comboKeyboardSpeed
            // 
            comboKeyboardSpeed.BorderColor = Color.White;
            comboKeyboardSpeed.ButtonColor = SystemColors.ControlLight;
            comboKeyboardSpeed.FlatStyle = FlatStyle.Flat;
            comboKeyboardSpeed.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboKeyboardSpeed.FormattingEnabled = true;
            comboKeyboardSpeed.ItemHeight = 32;
            comboKeyboardSpeed.Items.AddRange(new object[] { "Slow", "Normal", "Fast" });
            comboKeyboardSpeed.Location = new Point(230, 232);
            comboKeyboardSpeed.Margin = new Padding(4, 10, 4, 8);
            comboKeyboardSpeed.Name = "comboKeyboardSpeed";
            comboKeyboardSpeed.Size = new Size(291, 40);
            comboKeyboardSpeed.TabIndex = 39;
            comboKeyboardSpeed.TabStop = false;
            // 
            // checkShutdown
            // 
            checkShutdown.AutoSize = true;
            checkShutdown.Location = new Point(25, 185);
            checkShutdown.Name = "checkShutdown";
            checkShutdown.Size = new Size(154, 36);
            checkShutdown.TabIndex = 3;
            checkShutdown.Text = Strings.Shutdown;
            checkShutdown.UseVisualStyleBackColor = true;
            // 
            // checkSleep
            // 
            checkSleep.AutoSize = true;
            checkSleep.Location = new Point(25, 143);
            checkSleep.Name = "checkSleep";
            checkSleep.Size = new Size(105, 36);
            checkSleep.TabIndex = 2;
            checkSleep.Text = Strings.Sleep;
            checkSleep.UseVisualStyleBackColor = true;
            // 
            // checkBoot
            // 
            checkBoot.AutoSize = true;
            checkBoot.Location = new Point(25, 101);
            checkBoot.Name = "checkBoot";
            checkBoot.Size = new Size(96, 36);
            checkBoot.TabIndex = 1;
            checkBoot.Text = Strings.Boot;
            checkBoot.UseVisualStyleBackColor = true;
            // 
            // checkAwake
            // 
            checkAwake.AutoSize = true;
            checkAwake.Location = new Point(25, 59);
            checkAwake.Name = "checkAwake";
            checkAwake.Size = new Size(115, 36);
            checkAwake.TabIndex = 0;
            checkAwake.Text = Strings.Awake;
            checkAwake.UseVisualStyleBackColor = true;
            // 
            // groupOther
            // 
            groupOther.Controls.Add(checkUSBC);
            groupOther.Controls.Add(checkNoOverdrive);
            groupOther.Controls.Add(checkKeyboardAuto);
            groupOther.Controls.Add(checkTopmost);
            groupOther.Dock = DockStyle.Top;
            groupOther.Location = new Point(10, 647);
            groupOther.Name = "groupOther";
            groupOther.Size = new Size(844, 293);
            groupOther.TabIndex = 2;
            groupOther.TabStop = false;
            groupOther.Text = "Other";
            // 
            // checkUSBC
            // 
            checkUSBC.AutoSize = true;
            checkUSBC.Location = new Point(25, 210);
            checkUSBC.Name = "checkUSBC";
            checkUSBC.Size = new Size(659, 36);
            checkUSBC.TabIndex = 4;
            checkUSBC.Text = "Keep GPU disabled on USB-C charger in Optimized mode";
            checkUSBC.UseVisualStyleBackColor = true;
            // 
            // checkNoOverdrive
            // 
            checkNoOverdrive.AutoSize = true;
            checkNoOverdrive.Location = new Point(25, 156);
            checkNoOverdrive.Name = "checkNoOverdrive";
            checkNoOverdrive.Size = new Size(307, 36);
            checkNoOverdrive.TabIndex = 3;
            checkNoOverdrive.Text = Strings.DisableOverdrive;
            checkNoOverdrive.UseVisualStyleBackColor = true;
            // 
            // checkKeyboardAuto
            // 
            checkKeyboardAuto.AutoSize = true;
            checkKeyboardAuto.Location = new Point(25, 51);
            checkKeyboardAuto.MaximumSize = new Size(780, 0);
            checkKeyboardAuto.Name = "checkKeyboardAuto";
            checkKeyboardAuto.Size = new Size(712, 36);
            checkKeyboardAuto.TabIndex = 2;
            checkKeyboardAuto.Text = Strings.KeyboardAuto;
            checkKeyboardAuto.UseVisualStyleBackColor = true;
            // 
            // checkTopmost
            // 
            checkTopmost.AutoSize = true;
            checkTopmost.Location = new Point(25, 104);
            checkTopmost.Name = "checkTopmost";
            checkTopmost.Size = new Size(390, 36);
            checkTopmost.TabIndex = 1;
            checkTopmost.Text = Strings.WindowTop;
            checkTopmost.UseVisualStyleBackColor = true;
            // 
            // Extra
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 953);
            Controls.Add(groupOther);
            Controls.Add(groupLight);
            Controls.Add(groupBindings);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Extra";
            Padding = new Padding(10);
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Extra Settings";
            groupBindings.ResumeLayout(false);
            groupBindings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHelp).EndInit();
            groupLight.ResumeLayout(false);
            groupLight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBrightness).EndInit();
            groupOther.ResumeLayout(false);
            groupOther.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBindings;
        private Label labelM3;
        private RComboBox comboM3;
        private RComboBox comboM4;
        private Label labelM4;
        private TextBox textM4;
        private TextBox textM3;
        private TextBox textFNF4;
        private RComboBox comboFNF4;
        private Label labelFNF4;
        private GroupBox groupLight;
        private CheckBox checkSleep;
        private CheckBox checkBoot;
        private CheckBox checkAwake;
        private CheckBox checkShutdown;
        private Label labelSpeed;
        private RComboBox comboKeyboardSpeed;
        private GroupBox groupOther;
        private CheckBox checkTopmost;
        private CheckBox checkKeyboardAuto;
        private CheckBox checkNoOverdrive;
        private PictureBox pictureHelp;
        private TrackBar trackBrightness;
        private Label labelBrightness;
        private CheckBox checkUSBC;
    }
}