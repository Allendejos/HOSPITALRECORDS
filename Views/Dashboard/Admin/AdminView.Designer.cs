using Krypton.Toolkit;

namespace hrms_client.Views.Dashboard
{
    partial class AdminView

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminView));
            asidePanel = new KryptonPanel();
            buttonPanel = new KryptonPanel();
            kryptonButton1 = new KryptonButton();
            Pallete1 = new KryptonCustomPaletteBase(components);
            consultBtn = new KryptonButton();
            recordsBtn = new KryptonButton();
            kryptonPanel2 = new KryptonPanel();
            userRoleLabel = new KryptonLabel();
            userProfile = new KryptonPictureBox();
            usernameLabel = new KryptonLabel();
            mainPanelLoader = new KryptonPanel();
            Records = new KryptonButton();
            ((System.ComponentModel.ISupportInitialize)asidePanel).BeginInit();
            asidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonPanel).BeginInit();
            buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainPanelLoader).BeginInit();
            SuspendLayout();
            // 
            // asidePanel
            // 
            asidePanel.Controls.Add(buttonPanel);
            asidePanel.Controls.Add(kryptonPanel2);
            asidePanel.Dock = DockStyle.Left;
            asidePanel.Location = new Point(0, 0);
            asidePanel.Name = "asidePanel";
            asidePanel.Size = new Size(193, 652);
            asidePanel.StateCommon.Color1 = Color.FromArgb(4, 70, 87);
            asidePanel.StateCommon.Color2 = Color.FromArgb(58, 94, 116);
            asidePanel.StateCommon.ColorAngle = -55F;
            asidePanel.StateCommon.ColorStyle = PaletteColorStyle.Linear33;
            asidePanel.StateCommon.GraphicsHint = PaletteGraphicsHint.None;
            asidePanel.TabIndex = 0;
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(kryptonButton1);
            buttonPanel.Controls.Add(consultBtn);
            buttonPanel.Controls.Add(recordsBtn);
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.Location = new Point(0, 113);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(193, 539);
            buttonPanel.StateCommon.Color1 = Color.Transparent;
            buttonPanel.StateCommon.Color2 = Color.Transparent;
            buttonPanel.TabIndex = 1;
            // 
            // kryptonButton1
            // 
            kryptonButton1.LocalCustomPalette = Pallete1;
            kryptonButton1.Location = new Point(0, 155);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.Transparent;
            kryptonButton1.OverrideDefault.Back.Color2 = Color.Transparent;
            kryptonButton1.OverrideDefault.Back.ColorAngle = -45F;
            kryptonButton1.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Linear25;
            kryptonButton1.OverrideDefault.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonButton1.OverrideDefault.Border.Color1 = Color.Transparent;
            kryptonButton1.OverrideDefault.Border.Color2 = Color.Transparent;
            kryptonButton1.OverrideDefault.Content.AdjacentGap = 10;
            kryptonButton1.OverrideDefault.Content.Image.ImageH = PaletteRelativeAlign.Center;
            kryptonButton1.OverrideDefault.Content.Image.ImageV = PaletteRelativeAlign.Near;
            kryptonButton1.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(251, 251, 251);
            kryptonButton1.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(251, 251, 251);
            kryptonButton1.OverrideDefault.Content.ShortText.Font = new Font("Poppins Medium", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.PaletteMode = PaletteMode.Custom;
            kryptonButton1.Size = new Size(193, 63);
            kryptonButton1.StateCommon.Back.Color1 = Color.Transparent;
            kryptonButton1.StateCommon.Back.Color2 = Color.Transparent;
            kryptonButton1.StateCommon.Back.ColorAngle = -45F;
            kryptonButton1.StateCommon.Back.ColorStyle = PaletteColorStyle.Linear25;
            kryptonButton1.StateCommon.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateCommon.Border.Color1 = Color.Transparent;
            kryptonButton1.StateCommon.Border.Color2 = Color.Transparent;
            kryptonButton1.StateCommon.Content.AdjacentGap = 10;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.FromArgb(251, 251, 251);
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.FromArgb(251, 251, 251);
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Poppins", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonButton1.StateDisabled.Back.Color1 = Color.Gray;
            kryptonButton1.StateDisabled.Back.Color2 = Color.LightGray;
            kryptonButton1.StateDisabled.Back.ColorAngle = -45F;
            kryptonButton1.StateDisabled.Back.ColorStyle = PaletteColorStyle.Linear25;
            kryptonButton1.StateDisabled.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateDisabled.Border.Color1 = Color.Transparent;
            kryptonButton1.StateDisabled.Border.Color2 = Color.Transparent;
            kryptonButton1.StateDisabled.Content.AdjacentGap = 10;
            kryptonButton1.StateDisabled.Content.ShortText.Color1 = Color.DarkGray;
            kryptonButton1.StateDisabled.Content.ShortText.Color2 = Color.DarkGray;
            kryptonButton1.StateDisabled.Content.ShortText.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.StatePressed.Back.Color1 = Color.FromArgb(10, 80, 116);
            kryptonButton1.StatePressed.Back.Color2 = Color.FromArgb(65, 100, 120);
            kryptonButton1.StatePressed.Back.ColorAngle = -45F;
            kryptonButton1.StatePressed.Back.ColorStyle = PaletteColorStyle.Linear25;
            kryptonButton1.StatePressed.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StatePressed.Border.Color1 = Color.Transparent;
            kryptonButton1.StatePressed.Border.Color2 = Color.Transparent;
            kryptonButton1.StatePressed.Content.AdjacentGap = 10;
            kryptonButton1.StatePressed.Content.ShortText.Color1 = Color.FromArgb(251, 251, 251);
            kryptonButton1.StatePressed.Content.ShortText.Color2 = Color.FromArgb(251, 251, 251);
            kryptonButton1.StatePressed.Content.ShortText.Font = new Font("Poppins Medium", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(4, 70, 87);
            kryptonButton1.StateTracking.Back.Color2 = Color.FromArgb(58, 94, 116);
            kryptonButton1.StateTracking.Back.ColorAngle = -45F;
            kryptonButton1.StateTracking.Back.ColorStyle = PaletteColorStyle.Linear25;
            kryptonButton1.StateTracking.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateTracking.Border.Color1 = Color.Transparent;
            kryptonButton1.StateTracking.Border.Color2 = Color.Transparent;
            kryptonButton1.StateTracking.Content.AdjacentGap = 10;
            kryptonButton1.StateTracking.Content.ShortText.Color1 = Color.FromArgb(251, 251, 251);
            kryptonButton1.StateTracking.Content.ShortText.Color2 = Color.FromArgb(251, 251, 251);
            kryptonButton1.StateTracking.Content.ShortText.Font = new Font("Poppins Medium", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.TabIndex = 2;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Image = Properties.Resources.writing24;
            kryptonButton1.Values.Text = "Consultations";
            // 
            // Pallete1
            // 
            Pallete1.ButtonSpecs.FormMin.Orientation = PaletteButtonOrientation.FixedRight;
            Pallete1.ButtonSpecs.FormMin.Style = PaletteButtonStyle.Custom3;
            Pallete1.ButtonSpecs.FormMin.Text = "Minimize";
            Pallete1.UseThemeFormChromeBorderWidth = InheritBool.True;
            // 
            // consultBtn
            // 
            consultBtn.LocalCustomPalette = Pallete1;
            consultBtn.Location = new Point(3, 86);
            consultBtn.Name = "consultBtn";
            consultBtn.OverrideDefault.Back.Color1 = Color.Transparent;
            consultBtn.OverrideDefault.Back.Color2 = Color.Transparent;
            consultBtn.OverrideDefault.Back.ColorAngle = -45F;
            consultBtn.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Linear25;
            consultBtn.OverrideDefault.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            consultBtn.OverrideDefault.Border.Color1 = Color.Transparent;
            consultBtn.OverrideDefault.Border.Color2 = Color.Transparent;
            consultBtn.OverrideDefault.Content.AdjacentGap = 10;
            consultBtn.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(251, 251, 251);
            consultBtn.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(251, 251, 251);
            consultBtn.OverrideDefault.Content.ShortText.Font = new Font("Poppins Medium", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            consultBtn.PaletteMode = PaletteMode.Custom;
            consultBtn.Size = new Size(193, 63);
            consultBtn.StateCommon.Back.Color1 = Color.Transparent;
            consultBtn.StateCommon.Back.Color2 = Color.Transparent;
            consultBtn.StateCommon.Back.ColorAngle = -45F;
            consultBtn.StateCommon.Back.ColorStyle = PaletteColorStyle.Linear25;
            consultBtn.StateCommon.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            consultBtn.StateCommon.Border.Color1 = Color.Transparent;
            consultBtn.StateCommon.Border.Color2 = Color.Transparent;
            consultBtn.StateCommon.Content.AdjacentGap = 10;
            consultBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(251, 251, 251);
            consultBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(251, 251, 251);
            consultBtn.StateCommon.Content.ShortText.Font = new Font("Poppins", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            consultBtn.StateDisabled.Back.Color1 = Color.Gray;
            consultBtn.StateDisabled.Back.Color2 = Color.LightGray;
            consultBtn.StateDisabled.Back.ColorAngle = -45F;
            consultBtn.StateDisabled.Back.ColorStyle = PaletteColorStyle.Linear25;
            consultBtn.StateDisabled.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            consultBtn.StateDisabled.Border.Color1 = Color.Transparent;
            consultBtn.StateDisabled.Border.Color2 = Color.Transparent;
            consultBtn.StateDisabled.Content.AdjacentGap = 10;
            consultBtn.StateDisabled.Content.ShortText.Color1 = Color.DarkGray;
            consultBtn.StateDisabled.Content.ShortText.Color2 = Color.DarkGray;
            consultBtn.StateDisabled.Content.ShortText.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            consultBtn.StatePressed.Back.Color1 = Color.FromArgb(10, 80, 116);
            consultBtn.StatePressed.Back.Color2 = Color.FromArgb(65, 100, 120);
            consultBtn.StatePressed.Back.ColorAngle = -45F;
            consultBtn.StatePressed.Back.ColorStyle = PaletteColorStyle.Linear25;
            consultBtn.StatePressed.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            consultBtn.StatePressed.Border.Color1 = Color.Transparent;
            consultBtn.StatePressed.Border.Color2 = Color.Transparent;
            consultBtn.StatePressed.Content.AdjacentGap = 10;
            consultBtn.StatePressed.Content.ShortText.Color1 = Color.FromArgb(251, 251, 251);
            consultBtn.StatePressed.Content.ShortText.Color2 = Color.FromArgb(251, 251, 251);
            consultBtn.StatePressed.Content.ShortText.Font = new Font("Poppins Medium", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            consultBtn.StateTracking.Back.Color1 = Color.FromArgb(4, 70, 87);
            consultBtn.StateTracking.Back.Color2 = Color.FromArgb(58, 94, 116);
            consultBtn.StateTracking.Back.ColorAngle = -45F;
            consultBtn.StateTracking.Back.ColorStyle = PaletteColorStyle.Linear25;
            consultBtn.StateTracking.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            consultBtn.StateTracking.Border.Color1 = Color.Transparent;
            consultBtn.StateTracking.Border.Color2 = Color.Transparent;
            consultBtn.StateTracking.Content.AdjacentGap = 10;
            consultBtn.StateTracking.Content.ShortText.Color1 = Color.FromArgb(251, 251, 251);
            consultBtn.StateTracking.Content.ShortText.Color2 = Color.FromArgb(251, 251, 251);
            consultBtn.StateTracking.Content.ShortText.Font = new Font("Poppins Medium", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            consultBtn.TabIndex = 1;
            consultBtn.Values.DropDownArrowColor = Color.Empty;
            consultBtn.Values.Image = Properties.Resources.writing24;
            consultBtn.Values.Text = "Consultations";
            // 
            // recordsBtn
            // 
            recordsBtn.Location = new Point(0, 17);
            recordsBtn.Name = "recordsBtn";
            recordsBtn.OverrideDefault.Back.Color1 = Color.Transparent;
            recordsBtn.OverrideDefault.Back.Color2 = Color.Transparent;
            recordsBtn.OverrideDefault.Border.Color1 = Color.Transparent;
            recordsBtn.OverrideDefault.Border.Color2 = Color.Transparent;
            recordsBtn.OverrideDefault.Content.AdjacentGap = 15;
            recordsBtn.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            recordsBtn.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            recordsBtn.OverrideDefault.Content.ShortText.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recordsBtn.Size = new Size(193, 63);
            recordsBtn.StateTracking.Back.Color1 = Color.FromArgb(4, 70, 87);
            recordsBtn.StateTracking.Back.Color2 = Color.FromArgb(58, 94, 116);
            recordsBtn.StateTracking.Back.ColorAngle = -55F;
            recordsBtn.StateTracking.Back.ColorStyle = PaletteColorStyle.Linear33;
            recordsBtn.StateTracking.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            recordsBtn.StateTracking.Border.Color1 = Color.Transparent;
            recordsBtn.StateTracking.Border.Color2 = Color.Transparent;
            recordsBtn.StateTracking.Content.AdjacentGap = 15;
            recordsBtn.StateTracking.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            recordsBtn.StateTracking.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            recordsBtn.StateTracking.Content.ShortText.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recordsBtn.TabIndex = 0;
            recordsBtn.Values.DropDownArrowColor = Color.Empty;
            recordsBtn.Values.Image = Properties.Resources.writing24;
            recordsBtn.Values.Text = "Records";
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(userRoleLabel);
            kryptonPanel2.Controls.Add(userProfile);
            kryptonPanel2.Controls.Add(usernameLabel);
            kryptonPanel2.Dock = DockStyle.Top;
            kryptonPanel2.Location = new Point(0, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(193, 113);
            kryptonPanel2.StateCommon.Color1 = Color.Transparent;
            kryptonPanel2.TabIndex = 0;
            // 
            // userRoleLabel
            // 
            userRoleLabel.Location = new Point(75, 55);
            userRoleLabel.Name = "userRoleLabel";
            userRoleLabel.Size = new Size(52, 27);
            userRoleLabel.StateCommon.Image.ImageColorMap = Color.Yellow;
            userRoleLabel.StateCommon.Image.ImageColorTo = Color.LawnGreen;
            userRoleLabel.StateCommon.Padding = new Padding(5);
            userRoleLabel.StateCommon.ShortText.Color1 = Color.FromArgb(251, 251, 251);
            userRoleLabel.StateCommon.ShortText.Color2 = Color.FromArgb(251, 251, 251);
            userRoleLabel.StateCommon.ShortText.Font = new Font("Poppins", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userRoleLabel.TabIndex = 2;
            userRoleLabel.Values.ImageTransparentColor = Color.Transparent;
            userRoleLabel.Values.Text = "Admin";
            // 
            // userProfile
            // 
            userProfile.BackgroundImage = Properties.Resources.def_profile1;
            userProfile.BackgroundImageLayout = ImageLayout.Center;
            userProfile.Dock = DockStyle.Left;
            userProfile.Location = new Point(0, 0);
            userProfile.Name = "userProfile";
            userProfile.Size = new Size(81, 113);
            userProfile.SizeMode = PictureBoxSizeMode.Zoom;
            userProfile.TabIndex = 1;
            userProfile.TabStop = false;
            // 
            // usernameLabel
            // 
            usernameLabel.Location = new Point(75, 33);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(112, 30);
            usernameLabel.StateCommon.Image.ImageColorMap = Color.Yellow;
            usernameLabel.StateCommon.Image.ImageColorTo = Color.LawnGreen;
            usernameLabel.StateCommon.Padding = new Padding(5);
            usernameLabel.StateCommon.ShortText.Color1 = Color.FromArgb(251, 251, 251);
            usernameLabel.StateCommon.ShortText.Color2 = Color.FromArgb(251, 251, 251);
            usernameLabel.StateCommon.ShortText.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.TabIndex = 0;
            usernameLabel.Values.ImageTransparentColor = Color.Transparent;
            usernameLabel.Values.Text = "Jacinth Cedric";
            // 
            // mainPanelLoader
            // 
            mainPanelLoader.Dock = DockStyle.Fill;
            mainPanelLoader.Location = new Point(193, 0);
            mainPanelLoader.Name = "mainPanelLoader";
            mainPanelLoader.Palette = Pallete1;
            mainPanelLoader.PaletteMode = PaletteMode.Custom;
            mainPanelLoader.Size = new Size(914, 652);
            mainPanelLoader.StateCommon.Color1 = Color.Transparent;
            mainPanelLoader.StateCommon.Color2 = Color.Gainsboro;
            mainPanelLoader.StateCommon.ColorAngle = -45F;
            mainPanelLoader.StateCommon.ColorStyle = PaletteColorStyle.HalfCut;
            mainPanelLoader.StateCommon.GraphicsHint = PaletteGraphicsHint.None;
            mainPanelLoader.StateCommon.Image = Properties.Resources.Background;
            mainPanelLoader.StateCommon.ImageStyle = PaletteImageStyle.CenterMiddle;
            mainPanelLoader.TabIndex = 1;
            // 
            // Records
            // 
            Records.Location = new Point(0, 0);
            Records.Name = "Records";
            Records.Size = new Size(90, 25);
            Records.TabIndex = 0;
            Records.Values.DropDownArrowColor = Color.Empty;
            Records.Values.Image = Properties.Resources.records;
            Records.Values.Text = "Records";
            // 
            // AdminView
            // 
            AllowStatusStripMerge = false;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(251, 251, 251);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1107, 652);
            Controls.Add(mainPanelLoader);
            Controls.Add(asidePanel);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HeaderStyle = HeaderStyle.Custom3;
            Icon = (Icon)resources.GetObject("$this.Icon");
            LocalCustomPalette = Pallete1;
            MaximizeBox = false;
            MaximumSize = new Size(1107, 685);
            MinimizeBox = false;
            Name = "AdminView";
            PaletteMode = PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Back.Color1 = Color.FromArgb(58, 94, 116);
            StateCommon.Back.Color2 = Color.FromArgb(58, 94, 116);
            StateCommon.Back.GraphicsHint = PaletteGraphicsHint.None;
            StateCommon.Border.Color1 = Color.FromArgb(4, 70, 87);
            StateCommon.Border.Color2 = Color.FromArgb(4, 70, 87);
            StateCommon.Border.DrawBorders = PaletteDrawBorders.Bottom;
            StateCommon.Border.Rounding = 5F;
            StateCommon.Border.Width = 1;
            StateCommon.Header.Back.Color1 = Color.FromArgb(4, 70, 87);
            StateCommon.Header.Back.Color2 = Color.FromArgb(58, 94, 116);
            StateCommon.Header.Back.ColorAngle = -45F;
            StateCommon.Header.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            StateCommon.Header.Border.Color1 = Color.Transparent;
            StateCommon.Header.Border.Color2 = Color.Transparent;
            StateCommon.Header.Border.Rounding = 0F;
            StateCommon.Header.Border.Width = -10;
            StateCommon.Header.ButtonEdgeInset = 10;
            StateCommon.Header.Content.AdjacentGap = 5;
            StateCommon.Header.Content.Image.Effect = PaletteImageEffect.Light;
            StateCommon.Header.Content.Image.ImageColorMap = Color.White;
            StateCommon.Header.Content.Image.ImageColorTo = Color.White;
            StateCommon.Header.Content.Image.ImageH = PaletteRelativeAlign.Near;
            StateCommon.Header.Content.Image.ImageV = PaletteRelativeAlign.Center;
            StateCommon.Header.Content.Padding = new Padding(20, -1, -1, -1);
            StateCommon.Header.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            StateCommon.Header.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            StateCommon.Header.Content.ShortText.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StateCommon.OverlayHeaders = InheritBool.True;
            Text = "MediTrack";
            TransparencyKey = Color.Empty;
            ((System.ComponentModel.ISupportInitialize)asidePanel).EndInit();
            asidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)buttonPanel).EndInit();
            buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainPanelLoader).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private KryptonPanel asidePanel;
        private KryptonPanel mainPanelLoader;
        private KryptonCustomPaletteBase Pallete1;
        private KryptonPanel kryptonPanel2;
        private KryptonLabel usernameLabel;
        private KryptonPictureBox userProfile;
        private KryptonLabel userRoleLabel;
        private KryptonButton Records;
        private KryptonPanel buttonPanel;
        private KryptonButton recordsBtn;
        private KryptonButton kryptonButton1;
        private KryptonButton consultBtn;
    }
}