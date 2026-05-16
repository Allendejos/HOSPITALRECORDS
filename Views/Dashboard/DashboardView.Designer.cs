using Krypton.Toolkit;

namespace hrms_client.Views.Dashboard
{
    partial class DashboardView

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardView));
            Pallete1 = new KryptonCustomPaletteBase(components);
            Records = new KryptonButton();
            profilePanel = new KryptonPanel();
            profileDetails = new KryptonPanel();
            userRoleLabel = new KryptonLabel();
            usernameLabel = new KryptonLabel();
            userProfile = new KryptonPictureBox();
            asidePanel = new KryptonPanel();
            buttonsPanel = new KryptonPanel();
            billingsSelectedPanel = new KryptonPanel();
            qrScanSelectedPanel = new KryptonPanel();
            consultsSelectedPanel = new KryptonPanel();
            recordsSelectedPanel = new KryptonPanel();
            logoutBtn = new KryptonButton();
            billingsBtn = new KryptonButton();
            qrScanBtn = new KryptonButton();
            consultBtn = new KryptonButton();
            recordsBtn = new KryptonButton();
            mainPanelLoader = new KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)profilePanel).BeginInit();
            profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profileDetails).BeginInit();
            profileDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)asidePanel).BeginInit();
            asidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonsPanel).BeginInit();
            buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)billingsSelectedPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)qrScanSelectedPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)consultsSelectedPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recordsSelectedPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainPanelLoader).BeginInit();
            SuspendLayout();
            // 
            // Pallete1
            // 
            Pallete1.ButtonSpecs.FormMin.Orientation = PaletteButtonOrientation.FixedRight;
            Pallete1.ButtonSpecs.FormMin.Style = PaletteButtonStyle.Custom3;
            Pallete1.ButtonSpecs.FormMin.Text = "Minimize";
            Pallete1.UseThemeFormChromeBorderWidth = InheritBool.True;
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
            // profilePanel
            // 
            profilePanel.Controls.Add(profileDetails);
            profilePanel.Controls.Add(userProfile);
            profilePanel.Dock = DockStyle.Top;
            profilePanel.Location = new Point(0, 0);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(193, 93);
            profilePanel.StateCommon.Color1 = Color.Transparent;
            profilePanel.TabIndex = 0;
            // 
            // profileDetails
            // 
            profileDetails.Controls.Add(userRoleLabel);
            profileDetails.Controls.Add(usernameLabel);
            profileDetails.Dock = DockStyle.Fill;
            profileDetails.Location = new Point(75, 0);
            profileDetails.Name = "profileDetails";
            profileDetails.Size = new Size(118, 93);
            profileDetails.StateCommon.Color1 = Color.Transparent;
            profileDetails.StateCommon.Color2 = Color.Transparent;
            profileDetails.TabIndex = 0;
            // 
            // userRoleLabel
            // 
            userRoleLabel.Location = new Point(0, 47);
            userRoleLabel.Name = "userRoleLabel";
            userRoleLabel.Size = new Size(55, 27);
            userRoleLabel.StateCommon.Image.ImageColorMap = Color.Yellow;
            userRoleLabel.StateCommon.Image.ImageColorTo = Color.LawnGreen;
            userRoleLabel.StateCommon.Padding = new Padding(5);
            userRoleLabel.StateCommon.ShortText.Color1 = Color.FromArgb(251, 251, 251);
            userRoleLabel.StateCommon.ShortText.Color2 = Color.FromArgb(251, 251, 251);
            userRoleLabel.StateCommon.ShortText.Font = new Font("Poppins", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userRoleLabel.TabIndex = 2;
            userRoleLabel.Values.ImageTransparentColor = Color.Transparent;
            userRoleLabel.Values.Text = "Default";
            // 
            // usernameLabel
            // 
            usernameLabel.Location = new Point(0, 23);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(104, 30);
            usernameLabel.StateCommon.Image.ImageColorMap = Color.Yellow;
            usernameLabel.StateCommon.Image.ImageColorTo = Color.LawnGreen;
            usernameLabel.StateCommon.Padding = new Padding(5);
            usernameLabel.StateCommon.ShortText.Color1 = Color.FromArgb(251, 251, 251);
            usernameLabel.StateCommon.ShortText.Color2 = Color.FromArgb(251, 251, 251);
            usernameLabel.StateCommon.ShortText.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.TabIndex = 0;
            usernameLabel.Values.ImageTransparentColor = Color.Transparent;
            usernameLabel.Values.Text = "User Account";
            // 
            // userProfile
            // 
            userProfile.BackgroundImage = Properties.Resources.def_profile1;
            userProfile.BackgroundImageLayout = ImageLayout.Center;
            userProfile.Dock = DockStyle.Left;
            userProfile.Location = new Point(0, 0);
            userProfile.Name = "userProfile";
            userProfile.Size = new Size(75, 93);
            userProfile.SizeMode = PictureBoxSizeMode.Zoom;
            userProfile.TabIndex = 1;
            userProfile.TabStop = false;
            // 
            // asidePanel
            // 
            asidePanel.Controls.Add(buttonsPanel);
            asidePanel.Controls.Add(profilePanel);
            asidePanel.Dock = DockStyle.Left;
            asidePanel.Location = new Point(0, 0);
            asidePanel.Name = "asidePanel";
            asidePanel.Size = new Size(193, 650);
            asidePanel.StateCommon.Color1 = Color.FromArgb(4, 70, 87);
            asidePanel.StateCommon.Color2 = Color.FromArgb(58, 94, 116);
            asidePanel.StateCommon.ColorAngle = -55F;
            asidePanel.StateCommon.ColorStyle = PaletteColorStyle.Linear33;
            asidePanel.StateCommon.GraphicsHint = PaletteGraphicsHint.None;
            asidePanel.TabIndex = 0;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(billingsSelectedPanel);
            buttonsPanel.Controls.Add(qrScanSelectedPanel);
            buttonsPanel.Controls.Add(consultsSelectedPanel);
            buttonsPanel.Controls.Add(recordsSelectedPanel);
            buttonsPanel.Controls.Add(logoutBtn);
            buttonsPanel.Controls.Add(billingsBtn);
            buttonsPanel.Controls.Add(qrScanBtn);
            buttonsPanel.Controls.Add(consultBtn);
            buttonsPanel.Controls.Add(recordsBtn);
            buttonsPanel.Dock = DockStyle.Fill;
            buttonsPanel.Location = new Point(0, 93);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(193, 557);
            buttonsPanel.StateCommon.Color1 = Color.Transparent;
            buttonsPanel.StateCommon.Color2 = Color.Transparent;
            buttonsPanel.TabIndex = 2;
            // 
            // billingsSelectedPanel
            // 
            billingsSelectedPanel.Location = new Point(0, 243);
            billingsSelectedPanel.Name = "billingsSelectedPanel";
            billingsSelectedPanel.Size = new Size(11, 65);
            billingsSelectedPanel.StateCommon.Color1 = Color.FromArgb(19, 195, 51);
            billingsSelectedPanel.StateCommon.Color2 = Color.FromArgb(35, 215, 65);
            billingsSelectedPanel.StateCommon.ColorAngle = 50F;
            billingsSelectedPanel.StateCommon.ColorStyle = PaletteColorStyle.LinearShadow;
            billingsSelectedPanel.TabIndex = 1;
            // 
            // qrScanSelectedPanel
            // 
            qrScanSelectedPanel.Location = new Point(0, 172);
            qrScanSelectedPanel.Name = "qrScanSelectedPanel";
            qrScanSelectedPanel.Size = new Size(11, 65);
            qrScanSelectedPanel.StateCommon.Color1 = Color.FromArgb(19, 195, 51);
            qrScanSelectedPanel.StateCommon.Color2 = Color.FromArgb(35, 215, 65);
            qrScanSelectedPanel.StateCommon.ColorAngle = 50F;
            qrScanSelectedPanel.StateCommon.ColorStyle = PaletteColorStyle.LinearShadow;
            qrScanSelectedPanel.TabIndex = 5;
            // 
            // consultsSelectedPanel
            // 
            consultsSelectedPanel.Location = new Point(0, 101);
            consultsSelectedPanel.Name = "consultsSelectedPanel";
            consultsSelectedPanel.Size = new Size(11, 65);
            consultsSelectedPanel.StateCommon.Color1 = Color.FromArgb(19, 195, 51);
            consultsSelectedPanel.StateCommon.Color2 = Color.FromArgb(35, 215, 65);
            consultsSelectedPanel.StateCommon.ColorAngle = 50F;
            consultsSelectedPanel.StateCommon.ColorStyle = PaletteColorStyle.LinearShadow;
            consultsSelectedPanel.TabIndex = 1;
            // 
            // recordsSelectedPanel
            // 
            recordsSelectedPanel.Location = new Point(0, 30);
            recordsSelectedPanel.Name = "recordsSelectedPanel";
            recordsSelectedPanel.Size = new Size(11, 65);
            recordsSelectedPanel.StateCommon.Color1 = Color.FromArgb(19, 195, 51);
            recordsSelectedPanel.StateCommon.Color2 = Color.FromArgb(35, 215, 65);
            recordsSelectedPanel.StateCommon.ColorAngle = 50F;
            recordsSelectedPanel.StateCommon.ColorStyle = PaletteColorStyle.LinearShadow;
            recordsSelectedPanel.TabIndex = 0;
            // 
            // logoutBtn
            // 
            logoutBtn.Location = new Point(0, 469);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.OverrideDefault.Back.Color1 = Color.Transparent;
            logoutBtn.OverrideDefault.Back.Color2 = Color.Transparent;
            logoutBtn.OverrideDefault.Border.Color1 = Color.Transparent;
            logoutBtn.OverrideDefault.Border.Color2 = Color.Transparent;
            logoutBtn.OverrideDefault.Content.AdjacentGap = 10;
            logoutBtn.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            logoutBtn.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            logoutBtn.OverrideDefault.Content.ShortText.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutBtn.OverrideFocus.Back.Color1 = Color.FromArgb(4, 70, 87);
            logoutBtn.OverrideFocus.Back.Color2 = Color.FromArgb(58, 94, 116);
            logoutBtn.OverrideFocus.Back.ColorAngle = -55F;
            logoutBtn.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Linear33;
            logoutBtn.OverrideFocus.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            logoutBtn.OverrideFocus.Border.Color1 = Color.Transparent;
            logoutBtn.OverrideFocus.Border.Color2 = Color.Transparent;
            logoutBtn.OverrideFocus.Content.AdjacentGap = 10;
            logoutBtn.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            logoutBtn.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            logoutBtn.OverrideFocus.Content.ShortText.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutBtn.Size = new Size(193, 65);
            logoutBtn.StateCommon.Back.Color1 = Color.Transparent;
            logoutBtn.StateCommon.Back.Color2 = Color.Transparent;
            logoutBtn.StateCommon.Border.Color1 = Color.Transparent;
            logoutBtn.StateCommon.Border.Color2 = Color.Transparent;
            logoutBtn.StateCommon.Content.AdjacentGap = 10;
            logoutBtn.StateCommon.Content.Image.ImageH = PaletteRelativeAlign.Near;
            logoutBtn.StateCommon.Content.Padding = new Padding(20, 10, 10, 10);
            logoutBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            logoutBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            logoutBtn.StateCommon.Content.ShortText.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutBtn.StateDisabled.Back.Color1 = Color.FromArgb(200, 200, 200);
            logoutBtn.StateDisabled.Back.Color2 = Color.FromArgb(180, 180, 180);
            logoutBtn.StateDisabled.Border.Color1 = Color.Transparent;
            logoutBtn.StateDisabled.Border.Color2 = Color.Transparent;
            logoutBtn.StateDisabled.Content.AdjacentGap = 10;
            logoutBtn.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(150, 150, 150);
            logoutBtn.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(150, 150, 150);
            logoutBtn.StateDisabled.Content.ShortText.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutBtn.StateNormal.Back.Color1 = Color.Transparent;
            logoutBtn.StateNormal.Back.Color2 = Color.Transparent;
            logoutBtn.StateNormal.Border.Color1 = Color.Transparent;
            logoutBtn.StateNormal.Border.Color2 = Color.Transparent;
            logoutBtn.StateNormal.Content.AdjacentGap = 10;
            logoutBtn.StateNormal.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            logoutBtn.StateNormal.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            logoutBtn.StateNormal.Content.ShortText.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutBtn.StatePressed.Back.Color1 = Color.FromArgb(2, 50, 67);
            logoutBtn.StatePressed.Back.Color2 = Color.FromArgb(40, 80, 100);
            logoutBtn.StatePressed.Back.ColorAngle = -55F;
            logoutBtn.StatePressed.Back.ColorStyle = PaletteColorStyle.Linear33;
            logoutBtn.StatePressed.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            logoutBtn.StatePressed.Border.Color1 = Color.Transparent;
            logoutBtn.StatePressed.Border.Color2 = Color.Transparent;
            logoutBtn.StatePressed.Content.AdjacentGap = 10;
            logoutBtn.StatePressed.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            logoutBtn.StatePressed.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            logoutBtn.StatePressed.Content.ShortText.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutBtn.StateTracking.Back.Color1 = Color.FromArgb(4, 70, 87);
            logoutBtn.StateTracking.Back.Color2 = Color.FromArgb(58, 94, 116);
            logoutBtn.StateTracking.Back.ColorAngle = -55F;
            logoutBtn.StateTracking.Back.ColorStyle = PaletteColorStyle.Linear33;
            logoutBtn.StateTracking.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            logoutBtn.StateTracking.Border.Color1 = Color.Transparent;
            logoutBtn.StateTracking.Border.Color2 = Color.Transparent;
            logoutBtn.StateTracking.Content.AdjacentGap = 10;
            logoutBtn.StateTracking.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            logoutBtn.StateTracking.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            logoutBtn.StateTracking.Content.ShortText.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutBtn.TabIndex = 4;
            logoutBtn.Values.DropDownArrowColor = Color.Empty;
            logoutBtn.Values.Image = Properties.Resources.logout;
            logoutBtn.Values.Text = "Logout";
            // 
            // billingsBtn
            // 
            billingsBtn.Location = new Point(12, 243);
            billingsBtn.Name = "billingsBtn";
            billingsBtn.OverrideDefault.Back.Color1 = Color.Transparent;
            billingsBtn.OverrideDefault.Back.Color2 = Color.Transparent;
            billingsBtn.OverrideDefault.Border.Color1 = Color.Transparent;
            billingsBtn.OverrideDefault.Border.Color2 = Color.Transparent;
            billingsBtn.OverrideDefault.Content.AdjacentGap = 10;
            billingsBtn.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            billingsBtn.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            billingsBtn.OverrideDefault.Content.ShortText.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            billingsBtn.OverrideFocus.Back.Color1 = Color.FromArgb(4, 70, 87);
            billingsBtn.OverrideFocus.Back.Color2 = Color.FromArgb(58, 94, 116);
            billingsBtn.OverrideFocus.Back.ColorAngle = -55F;
            billingsBtn.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Linear33;
            billingsBtn.OverrideFocus.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            billingsBtn.OverrideFocus.Border.Color1 = Color.Transparent;
            billingsBtn.OverrideFocus.Border.Color2 = Color.Transparent;
            billingsBtn.OverrideFocus.Content.AdjacentGap = 10;
            billingsBtn.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            billingsBtn.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            billingsBtn.OverrideFocus.Content.ShortText.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            billingsBtn.Size = new Size(181, 65);
            billingsBtn.StateCommon.Back.Color1 = Color.Transparent;
            billingsBtn.StateCommon.Back.Color2 = Color.Transparent;
            billingsBtn.StateCommon.Border.Color1 = Color.Transparent;
            billingsBtn.StateCommon.Border.Color2 = Color.Transparent;
            billingsBtn.StateCommon.Content.AdjacentGap = 10;
            billingsBtn.StateCommon.Content.Image.ImageH = PaletteRelativeAlign.Near;
            billingsBtn.StateCommon.Content.Padding = new Padding(20, 10, 10, 10);
            billingsBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            billingsBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            billingsBtn.StateCommon.Content.ShortText.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            billingsBtn.StateDisabled.Back.Color1 = Color.FromArgb(200, 200, 200);
            billingsBtn.StateDisabled.Back.Color2 = Color.FromArgb(180, 180, 180);
            billingsBtn.StateDisabled.Border.Color1 = Color.Transparent;
            billingsBtn.StateDisabled.Border.Color2 = Color.Transparent;
            billingsBtn.StateDisabled.Content.AdjacentGap = 10;
            billingsBtn.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(150, 150, 150);
            billingsBtn.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(150, 150, 150);
            billingsBtn.StateDisabled.Content.ShortText.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            billingsBtn.StateNormal.Back.Color1 = Color.Transparent;
            billingsBtn.StateNormal.Back.Color2 = Color.Transparent;
            billingsBtn.StateNormal.Border.Color1 = Color.Transparent;
            billingsBtn.StateNormal.Border.Color2 = Color.Transparent;
            billingsBtn.StateNormal.Content.AdjacentGap = 10;
            billingsBtn.StateNormal.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            billingsBtn.StateNormal.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            billingsBtn.StateNormal.Content.ShortText.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            billingsBtn.StatePressed.Back.Color1 = Color.FromArgb(2, 50, 67);
            billingsBtn.StatePressed.Back.Color2 = Color.FromArgb(40, 80, 100);
            billingsBtn.StatePressed.Back.ColorAngle = -55F;
            billingsBtn.StatePressed.Back.ColorStyle = PaletteColorStyle.Linear33;
            billingsBtn.StatePressed.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            billingsBtn.StatePressed.Border.Color1 = Color.Transparent;
            billingsBtn.StatePressed.Border.Color2 = Color.Transparent;
            billingsBtn.StatePressed.Content.AdjacentGap = 10;
            billingsBtn.StatePressed.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            billingsBtn.StatePressed.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            billingsBtn.StatePressed.Content.ShortText.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            billingsBtn.StateTracking.Back.Color1 = Color.FromArgb(4, 70, 87);
            billingsBtn.StateTracking.Back.Color2 = Color.FromArgb(58, 94, 116);
            billingsBtn.StateTracking.Back.ColorAngle = -55F;
            billingsBtn.StateTracking.Back.ColorStyle = PaletteColorStyle.Linear33;
            billingsBtn.StateTracking.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            billingsBtn.StateTracking.Border.Color1 = Color.Transparent;
            billingsBtn.StateTracking.Border.Color2 = Color.Transparent;
            billingsBtn.StateTracking.Content.AdjacentGap = 10;
            billingsBtn.StateTracking.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            billingsBtn.StateTracking.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            billingsBtn.StateTracking.Content.ShortText.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            billingsBtn.TabIndex = 3;
            billingsBtn.Values.DropDownArrowColor = Color.Empty;
            billingsBtn.Values.Image = Properties.Resources.bill24;
            billingsBtn.Values.Text = "Billings";
            // 
            // qrScanBtn
            // 
            qrScanBtn.Location = new Point(12, 172);
            qrScanBtn.Name = "qrScanBtn";
            qrScanBtn.OverrideDefault.Back.Color1 = Color.Transparent;
            qrScanBtn.OverrideDefault.Back.Color2 = Color.Transparent;
            qrScanBtn.OverrideDefault.Border.Color1 = Color.Transparent;
            qrScanBtn.OverrideDefault.Border.Color2 = Color.Transparent;
            qrScanBtn.OverrideDefault.Content.AdjacentGap = 10;
            qrScanBtn.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            qrScanBtn.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            qrScanBtn.OverrideDefault.Content.ShortText.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            qrScanBtn.OverrideFocus.Back.Color1 = Color.FromArgb(4, 70, 87);
            qrScanBtn.OverrideFocus.Back.Color2 = Color.FromArgb(58, 94, 116);
            qrScanBtn.OverrideFocus.Back.ColorAngle = -55F;
            qrScanBtn.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Linear33;
            qrScanBtn.OverrideFocus.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            qrScanBtn.OverrideFocus.Border.Color1 = Color.Transparent;
            qrScanBtn.OverrideFocus.Border.Color2 = Color.Transparent;
            qrScanBtn.OverrideFocus.Content.AdjacentGap = 10;
            qrScanBtn.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            qrScanBtn.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            qrScanBtn.OverrideFocus.Content.ShortText.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            qrScanBtn.Size = new Size(181, 65);
            qrScanBtn.StateCommon.Back.Color1 = Color.Transparent;
            qrScanBtn.StateCommon.Back.Color2 = Color.Transparent;
            qrScanBtn.StateCommon.Border.Color1 = Color.Transparent;
            qrScanBtn.StateCommon.Border.Color2 = Color.Transparent;
            qrScanBtn.StateCommon.Content.AdjacentGap = 10;
            qrScanBtn.StateCommon.Content.Image.ImageH = PaletteRelativeAlign.Near;
            qrScanBtn.StateCommon.Content.Padding = new Padding(20, 10, 10, 10);
            qrScanBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            qrScanBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            qrScanBtn.StateCommon.Content.ShortText.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            qrScanBtn.StateDisabled.Back.Color1 = Color.FromArgb(200, 200, 200);
            qrScanBtn.StateDisabled.Back.Color2 = Color.FromArgb(180, 180, 180);
            qrScanBtn.StateDisabled.Border.Color1 = Color.Transparent;
            qrScanBtn.StateDisabled.Border.Color2 = Color.Transparent;
            qrScanBtn.StateDisabled.Content.AdjacentGap = 10;
            qrScanBtn.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(150, 150, 150);
            qrScanBtn.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(150, 150, 150);
            qrScanBtn.StateDisabled.Content.ShortText.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            qrScanBtn.StateNormal.Back.Color1 = Color.Transparent;
            qrScanBtn.StateNormal.Back.Color2 = Color.Transparent;
            qrScanBtn.StateNormal.Border.Color1 = Color.Transparent;
            qrScanBtn.StateNormal.Border.Color2 = Color.Transparent;
            qrScanBtn.StateNormal.Content.AdjacentGap = 10;
            qrScanBtn.StateNormal.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            qrScanBtn.StateNormal.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            qrScanBtn.StateNormal.Content.ShortText.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            qrScanBtn.StatePressed.Back.Color1 = Color.FromArgb(2, 50, 67);
            qrScanBtn.StatePressed.Back.Color2 = Color.FromArgb(40, 80, 100);
            qrScanBtn.StatePressed.Back.ColorAngle = -55F;
            qrScanBtn.StatePressed.Back.ColorStyle = PaletteColorStyle.Linear33;
            qrScanBtn.StatePressed.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            qrScanBtn.StatePressed.Border.Color1 = Color.Transparent;
            qrScanBtn.StatePressed.Border.Color2 = Color.Transparent;
            qrScanBtn.StatePressed.Content.AdjacentGap = 10;
            qrScanBtn.StatePressed.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            qrScanBtn.StatePressed.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            qrScanBtn.StatePressed.Content.ShortText.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            qrScanBtn.StateTracking.Back.Color1 = Color.FromArgb(4, 70, 87);
            qrScanBtn.StateTracking.Back.Color2 = Color.FromArgb(58, 94, 116);
            qrScanBtn.StateTracking.Back.ColorAngle = -55F;
            qrScanBtn.StateTracking.Back.ColorStyle = PaletteColorStyle.Linear33;
            qrScanBtn.StateTracking.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            qrScanBtn.StateTracking.Border.Color1 = Color.Transparent;
            qrScanBtn.StateTracking.Border.Color2 = Color.Transparent;
            qrScanBtn.StateTracking.Content.AdjacentGap = 10;
            qrScanBtn.StateTracking.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            qrScanBtn.StateTracking.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            qrScanBtn.StateTracking.Content.ShortText.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            qrScanBtn.TabIndex = 2;
            qrScanBtn.Values.DropDownArrowColor = Color.Empty;
            qrScanBtn.Values.Image = Properties.Resources.qr24white;
            qrScanBtn.Values.Text = "QR Page";
            // 
            // consultBtn
            // 
            consultBtn.Location = new Point(12, 101);
            consultBtn.Name = "consultBtn";
            consultBtn.OverrideDefault.Back.Color1 = Color.Transparent;
            consultBtn.OverrideDefault.Back.Color2 = Color.Transparent;
            consultBtn.OverrideDefault.Border.Color1 = Color.Transparent;
            consultBtn.OverrideDefault.Border.Color2 = Color.Transparent;
            consultBtn.OverrideDefault.Content.AdjacentGap = 10;
            consultBtn.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            consultBtn.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            consultBtn.OverrideDefault.Content.ShortText.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            consultBtn.OverrideFocus.Back.Color1 = Color.FromArgb(4, 70, 87);
            consultBtn.OverrideFocus.Back.Color2 = Color.FromArgb(58, 94, 116);
            consultBtn.OverrideFocus.Back.ColorAngle = -55F;
            consultBtn.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Linear33;
            consultBtn.OverrideFocus.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            consultBtn.OverrideFocus.Border.Color1 = Color.Transparent;
            consultBtn.OverrideFocus.Border.Color2 = Color.Transparent;
            consultBtn.OverrideFocus.Content.AdjacentGap = 10;
            consultBtn.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            consultBtn.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            consultBtn.OverrideFocus.Content.ShortText.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            consultBtn.Size = new Size(181, 65);
            consultBtn.StateCommon.Back.Color1 = Color.Transparent;
            consultBtn.StateCommon.Back.Color2 = Color.Transparent;
            consultBtn.StateCommon.Border.Color1 = Color.Transparent;
            consultBtn.StateCommon.Border.Color2 = Color.Transparent;
            consultBtn.StateCommon.Content.AdjacentGap = 10;
            consultBtn.StateCommon.Content.Image.ImageH = PaletteRelativeAlign.Near;
            consultBtn.StateCommon.Content.Padding = new Padding(20, 10, 10, 10);
            consultBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            consultBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            consultBtn.StateCommon.Content.ShortText.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            consultBtn.StateDisabled.Back.Color1 = Color.FromArgb(200, 200, 200);
            consultBtn.StateDisabled.Back.Color2 = Color.FromArgb(180, 180, 180);
            consultBtn.StateDisabled.Border.Color1 = Color.Transparent;
            consultBtn.StateDisabled.Border.Color2 = Color.Transparent;
            consultBtn.StateDisabled.Content.AdjacentGap = 10;
            consultBtn.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(150, 150, 150);
            consultBtn.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(150, 150, 150);
            consultBtn.StateDisabled.Content.ShortText.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            consultBtn.StateNormal.Back.Color1 = Color.Transparent;
            consultBtn.StateNormal.Back.Color2 = Color.Transparent;
            consultBtn.StateNormal.Border.Color1 = Color.Transparent;
            consultBtn.StateNormal.Border.Color2 = Color.Transparent;
            consultBtn.StateNormal.Content.AdjacentGap = 10;
            consultBtn.StateNormal.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            consultBtn.StateNormal.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            consultBtn.StateNormal.Content.ShortText.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            consultBtn.StatePressed.Back.Color1 = Color.FromArgb(2, 50, 67);
            consultBtn.StatePressed.Back.Color2 = Color.FromArgb(40, 80, 100);
            consultBtn.StatePressed.Back.ColorAngle = -55F;
            consultBtn.StatePressed.Back.ColorStyle = PaletteColorStyle.Linear33;
            consultBtn.StatePressed.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            consultBtn.StatePressed.Border.Color1 = Color.Transparent;
            consultBtn.StatePressed.Border.Color2 = Color.Transparent;
            consultBtn.StatePressed.Content.AdjacentGap = 10;
            consultBtn.StatePressed.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            consultBtn.StatePressed.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            consultBtn.StatePressed.Content.ShortText.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            consultBtn.StateTracking.Back.Color1 = Color.FromArgb(4, 70, 87);
            consultBtn.StateTracking.Back.Color2 = Color.FromArgb(58, 94, 116);
            consultBtn.StateTracking.Back.ColorAngle = -55F;
            consultBtn.StateTracking.Back.ColorStyle = PaletteColorStyle.Linear33;
            consultBtn.StateTracking.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            consultBtn.StateTracking.Border.Color1 = Color.Transparent;
            consultBtn.StateTracking.Border.Color2 = Color.Transparent;
            consultBtn.StateTracking.Content.AdjacentGap = 10;
            consultBtn.StateTracking.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            consultBtn.StateTracking.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            consultBtn.StateTracking.Content.ShortText.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            consultBtn.TabIndex = 1;
            consultBtn.Values.DropDownArrowColor = Color.Empty;
            consultBtn.Values.Image = Properties.Resources.consult24;
            consultBtn.Values.Text = "Consults";
            // 
            // recordsBtn
            // 
            recordsBtn.Location = new Point(12, 30);
            recordsBtn.Name = "recordsBtn";
            recordsBtn.OverrideDefault.Back.Color1 = Color.Transparent;
            recordsBtn.OverrideDefault.Back.Color2 = Color.Transparent;
            recordsBtn.OverrideDefault.Border.Color1 = Color.Transparent;
            recordsBtn.OverrideDefault.Border.Color2 = Color.Transparent;
            recordsBtn.OverrideDefault.Content.AdjacentGap = 10;
            recordsBtn.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            recordsBtn.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            recordsBtn.OverrideDefault.Content.ShortText.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recordsBtn.OverrideFocus.Back.Color1 = Color.FromArgb(4, 70, 87);
            recordsBtn.OverrideFocus.Back.Color2 = Color.FromArgb(58, 94, 116);
            recordsBtn.OverrideFocus.Back.ColorAngle = -55F;
            recordsBtn.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Linear33;
            recordsBtn.OverrideFocus.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            recordsBtn.OverrideFocus.Border.Color1 = Color.Transparent;
            recordsBtn.OverrideFocus.Border.Color2 = Color.Transparent;
            recordsBtn.OverrideFocus.Content.AdjacentGap = 10;
            recordsBtn.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            recordsBtn.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            recordsBtn.OverrideFocus.Content.ShortText.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recordsBtn.Size = new Size(181, 65);
            recordsBtn.StateCommon.Back.Color1 = Color.Transparent;
            recordsBtn.StateCommon.Back.Color2 = Color.Transparent;
            recordsBtn.StateCommon.Border.Color1 = Color.Transparent;
            recordsBtn.StateCommon.Border.Color2 = Color.Transparent;
            recordsBtn.StateCommon.Content.AdjacentGap = 10;
            recordsBtn.StateCommon.Content.Image.ImageH = PaletteRelativeAlign.Near;
            recordsBtn.StateCommon.Content.Padding = new Padding(20, 10, 10, 10);
            recordsBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            recordsBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            recordsBtn.StateCommon.Content.ShortText.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recordsBtn.StateDisabled.Back.Color1 = Color.FromArgb(200, 200, 200);
            recordsBtn.StateDisabled.Back.Color2 = Color.FromArgb(180, 180, 180);
            recordsBtn.StateDisabled.Border.Color1 = Color.Transparent;
            recordsBtn.StateDisabled.Border.Color2 = Color.Transparent;
            recordsBtn.StateDisabled.Content.AdjacentGap = 10;
            recordsBtn.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(150, 150, 150);
            recordsBtn.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(150, 150, 150);
            recordsBtn.StateDisabled.Content.ShortText.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recordsBtn.StateNormal.Back.Color1 = Color.Transparent;
            recordsBtn.StateNormal.Back.Color2 = Color.Transparent;
            recordsBtn.StateNormal.Border.Color1 = Color.Transparent;
            recordsBtn.StateNormal.Border.Color2 = Color.Transparent;
            recordsBtn.StateNormal.Content.AdjacentGap = 10;
            recordsBtn.StateNormal.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            recordsBtn.StateNormal.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            recordsBtn.StateNormal.Content.ShortText.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recordsBtn.StatePressed.Back.Color1 = Color.FromArgb(2, 50, 67);
            recordsBtn.StatePressed.Back.Color2 = Color.FromArgb(40, 80, 100);
            recordsBtn.StatePressed.Back.ColorAngle = -55F;
            recordsBtn.StatePressed.Back.ColorStyle = PaletteColorStyle.Linear33;
            recordsBtn.StatePressed.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            recordsBtn.StatePressed.Border.Color1 = Color.Transparent;
            recordsBtn.StatePressed.Border.Color2 = Color.Transparent;
            recordsBtn.StatePressed.Content.AdjacentGap = 10;
            recordsBtn.StatePressed.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            recordsBtn.StatePressed.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            recordsBtn.StatePressed.Content.ShortText.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recordsBtn.StateTracking.Back.Color1 = Color.FromArgb(4, 70, 87);
            recordsBtn.StateTracking.Back.Color2 = Color.FromArgb(58, 94, 116);
            recordsBtn.StateTracking.Back.ColorAngle = -55F;
            recordsBtn.StateTracking.Back.ColorStyle = PaletteColorStyle.Linear33;
            recordsBtn.StateTracking.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            recordsBtn.StateTracking.Border.Color1 = Color.Transparent;
            recordsBtn.StateTracking.Border.Color2 = Color.Transparent;
            recordsBtn.StateTracking.Content.AdjacentGap = 10;
            recordsBtn.StateTracking.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            recordsBtn.StateTracking.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            recordsBtn.StateTracking.Content.ShortText.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recordsBtn.TabIndex = 0;
            recordsBtn.Values.DropDownArrowColor = Color.Empty;
            recordsBtn.Values.Image = Properties.Resources.record24;
            recordsBtn.Values.Text = "Records";
            // 
            // mainPanelLoader
            // 
            mainPanelLoader.Dock = DockStyle.Fill;
            mainPanelLoader.Location = new Point(193, 0);
            mainPanelLoader.Name = "mainPanelLoader";
            mainPanelLoader.Size = new Size(916, 650);
            mainPanelLoader.StateCommon.Color1 = Color.Transparent;
            mainPanelLoader.StateCommon.Color2 = Color.Transparent;
            mainPanelLoader.StateCommon.Image = Properties.Resources.Background;
            mainPanelLoader.StateCommon.ImageStyle = PaletteImageStyle.Stretch;
            mainPanelLoader.TabIndex = 3;
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(251, 251, 251);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1109, 650);
            Controls.Add(mainPanelLoader);
            Controls.Add(asidePanel);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            FormTitleAlign = PaletteRelativeAlign.Center;
            HeaderStyle = HeaderStyle.Primary;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            LocalCustomPalette = Pallete1;
            MaximizeBox = false;
            MaximumSize = new Size(1109, 688);
            MinimizeBox = false;
            MinimumSize = new Size(1109, 688);
            Name = "DashboardView";
            PaletteMode = PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Back.Color1 = Color.FromArgb(58, 94, 116);
            StateCommon.Back.Color2 = Color.FromArgb(58, 94, 116);
            StateCommon.Back.Draw = InheritBool.True;
            StateCommon.Back.GraphicsHint = PaletteGraphicsHint.None;
            StateCommon.Border.Color1 = Color.Transparent;
            StateCommon.Border.Color2 = Color.Transparent;
            StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
            StateCommon.Border.Rounding = 5F;
            StateCommon.Header.Back.Color1 = Color.FromArgb(4, 70, 87);
            StateCommon.Header.Back.Color2 = Color.FromArgb(58, 94, 116);
            StateCommon.Header.Back.ColorAngle = 94F;
            StateCommon.Header.Back.ColorStyle = PaletteColorStyle.Linear33;
            StateCommon.Header.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            StateCommon.Header.Border.Color1 = Color.Transparent;
            StateCommon.Header.Border.Color2 = Color.Transparent;
            StateCommon.Header.Border.Draw = InheritBool.False;
            StateCommon.Header.Border.GraphicsHint = PaletteGraphicsHint.None;
            StateCommon.Header.Border.Rounding = 0F;
            StateCommon.Header.Border.Width = 10;
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
            Text = "MediTrack";
            TransparencyKey = Color.Empty;
            UseDropShadow = true;
            ((System.ComponentModel.ISupportInitialize)profilePanel).EndInit();
            profilePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profileDetails).EndInit();
            profileDetails.ResumeLayout(false);
            profileDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)asidePanel).EndInit();
            asidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)buttonsPanel).EndInit();
            buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)billingsSelectedPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)qrScanSelectedPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)consultsSelectedPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)recordsSelectedPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainPanelLoader).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private KryptonCustomPaletteBase Pallete1;
        private KryptonButton Records;
        private KryptonPanel profilePanel;
        private KryptonLabel userRoleLabel;
        private KryptonPictureBox userProfile;
        private KryptonLabel usernameLabel;
        private KryptonPanel asidePanel;
        private KryptonPanel buttonsPanel;
        private KryptonButton logoutBtn;
        private KryptonButton billingsBtn;
        private KryptonButton qrScanBtn;
        private KryptonButton consultBtn;
        private KryptonButton recordsBtn;
        private KryptonPanel profileDetails;
        private KryptonPanel billingsSelectedPanel;
        private KryptonPanel qrScanSelectedPanel;
        private KryptonPanel consultsSelectedPanel;
        private KryptonPanel recordsSelectedPanel;
        private KryptonPanel mainPanelLoader;
    }
}