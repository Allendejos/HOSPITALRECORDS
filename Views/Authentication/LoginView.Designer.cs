using Krypton.Toolkit;

namespace hrms_client.Views
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            kryptonPalette = new KryptonCustomPaletteBase(components);
            panelPalette = new KryptonCustomPaletteBase(components);
            label1 = new Label();
            panel1 = new Panel();
            usernameText = new KryptonTextBox();
            loginBtn = new KryptonButton();
            signUpLink = new KryptonLinkLabel();
            kryptonLabel1 = new KryptonLabel();
            passwordText = new KryptonTextBox();
            label3 = new Label();
            label2 = new Label();
            kryptonPanel1 = new KryptonPanel();
            kryptonWrapLabel1 = new KryptonWrapLabel();
            kryptonPictureBox1 = new KryptonPictureBox();
            kryptonLabel3 = new KryptonLabel();
            kryptonLabel2 = new KryptonLabel();
            buttonSpecAny1 = new ButtonSpecAny();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // kryptonPalette
            // 
            kryptonPalette.UseThemeFormChromeBorderWidth = InheritBool.True;
            // 
            // panelPalette
            // 
            panelPalette.UseThemeFormChromeBorderWidth = InheritBool.True;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Poppins SemiBold", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 33);
            label1.Name = "label1";
            label1.Size = new Size(117, 60);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 94, 116);
            panel1.Controls.Add(usernameText);
            panel1.Controls.Add(loginBtn);
            panel1.Controls.Add(signUpLink);
            panel1.Controls.Add(kryptonLabel1);
            panel1.Controls.Add(passwordText);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(59, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 563);
            panel1.TabIndex = 1;
            // 
            // usernameText
            // 
            usernameText.AlwaysActive = false;
            usernameText.CueHint.Color1 = Color.DimGray;
            usernameText.CueHint.CueHintText = "Enter your email or username";
            usernameText.CueHint.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameText.CueHint.TextV = PaletteRelativeAlign.Near;
            usernameText.Cursor = Cursors.IBeam;
            usernameText.InputControlStyle = InputControlStyle.Custom3;
            usernameText.LocalCustomPalette = kryptonPalette;
            usernameText.Location = new Point(48, 173);
            usernameText.Name = "usernameText";
            usernameText.PaletteMode = PaletteMode.Custom;
            usernameText.Size = new Size(361, 46);
            usernameText.StateCommon.Back.Color1 = Color.FromArgb(251, 251, 251);
            usernameText.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            usernameText.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            usernameText.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            usernameText.StateCommon.Border.Rounding = 5F;
            usernameText.StateCommon.Border.Width = 1;
            usernameText.StateCommon.Content.Color1 = Color.DimGray;
            usernameText.StateCommon.Content.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameText.StateCommon.Content.Padding = new Padding(10);
            usernameText.TabIndex = 8;
            // 
            // loginBtn
            // 
            loginBtn.LocalCustomPalette = kryptonPalette;
            loginBtn.Location = new Point(143, 395);
            loginBtn.Name = "loginBtn";
            loginBtn.OverrideDefault.Back.Color1 = Color.FromArgb(251, 252, 252);
            loginBtn.OverrideDefault.Back.Color2 = Color.FromArgb(251, 252, 252);
            loginBtn.OverrideDefault.Border.Rounding = 10F;
            loginBtn.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(58, 94, 116);
            loginBtn.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(58, 94, 116);
            loginBtn.OverrideDefault.Content.ShortText.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.PaletteMode = PaletteMode.Custom;
            loginBtn.Size = new Size(162, 54);
            loginBtn.StateCommon.Back.Color1 = Color.FromArgb(251, 252, 252);
            loginBtn.StateCommon.Back.Color2 = Color.FromArgb(251, 252, 252);
            loginBtn.StateCommon.Border.Color1 = Color.FromArgb(40, 73, 87);
            loginBtn.StateCommon.Border.Color2 = Color.FromArgb(40, 73, 87);
            loginBtn.StateCommon.Border.Rounding = 10F;
            loginBtn.StateCommon.Border.Width = 2;
            loginBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(58, 94, 116);
            loginBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(58, 94, 116);
            loginBtn.StateCommon.Content.ShortText.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.StatePressed.Back.Color1 = Color.FromArgb(200, 200, 200);
            loginBtn.StatePressed.Back.Color2 = Color.FromArgb(200, 200, 200);
            loginBtn.StatePressed.Border.Color1 = Color.FromArgb(30, 50, 70);
            loginBtn.StatePressed.Border.Color2 = Color.FromArgb(30, 50, 70);
            loginBtn.StatePressed.Border.Rounding = 10F;
            loginBtn.StatePressed.Content.ShortText.Color1 = Color.FromArgb(40, 80, 100);
            loginBtn.StatePressed.Content.ShortText.Color2 = Color.FromArgb(40, 80, 100);
            loginBtn.StateTracking.Back.Color1 = Color.FromArgb(230, 230, 230);
            loginBtn.StateTracking.Back.Color2 = Color.FromArgb(230, 230, 230);
            loginBtn.StateTracking.Border.Color1 = Color.FromArgb(60, 100, 120);
            loginBtn.StateTracking.Border.Color2 = Color.FromArgb(60, 100, 120);
            loginBtn.StateTracking.Border.Rounding = 10F;
            loginBtn.StateTracking.Content.ShortText.Color1 = Color.FromArgb(80, 120, 140);
            loginBtn.StateTracking.Content.ShortText.Color2 = Color.FromArgb(80, 120, 140);
            loginBtn.TabIndex = 7;
            loginBtn.Values.DropDownArrowColor = Color.Empty;
            loginBtn.Values.Text = "Login";
            // 
            // signUpLink
            // 
            signUpLink.LinkBehavior = KryptonLinkBehavior.HoverUnderline;
            signUpLink.Location = new Point(248, 498);
            signUpLink.Name = "signUpLink";
            signUpLink.OverrideFocus.ShortText.Color1 = Color.FromArgb(220, 220, 220);
            signUpLink.OverrideFocus.ShortText.Color2 = Color.FromArgb(220, 220, 220);
            signUpLink.OverrideNotVisited.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            signUpLink.OverrideNotVisited.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            signUpLink.OverrideVisited.ShortText.Color1 = Color.FromArgb(180, 180, 180);
            signUpLink.OverrideVisited.ShortText.Color2 = Color.FromArgb(180, 180, 180);
            signUpLink.Size = new Size(85, 31);
            signUpLink.StateCommon.ShortText.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signUpLink.StateNormal.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            signUpLink.StateNormal.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            signUpLink.StateNormal.ShortText.Font = new Font("Poppins", 14F);
            signUpLink.TabIndex = 6;
            signUpLink.Values.Text = "Sign Up";
            signUpLink.LinkClicked += signUpLink_LinkClicked;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(104, 498);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(138, 31);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Poppins SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 5;
            kryptonLabel1.Values.Text = "No Account? ";
            // 
            // passwordText
            // 
            passwordText.AlwaysActive = false;
            passwordText.CueHint.Color1 = Color.DimGray;
            passwordText.CueHint.CueHintText = "Enter Password";
            passwordText.CueHint.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordText.CueHint.TextV = PaletteRelativeAlign.Near;
            passwordText.Cursor = Cursors.IBeam;
            passwordText.InputControlStyle = InputControlStyle.Custom3;
            passwordText.LocalCustomPalette = kryptonPalette;
            passwordText.Location = new Point(48, 294);
            passwordText.Name = "passwordText";
            passwordText.PaletteMode = PaletteMode.Custom;
            passwordText.Size = new Size(361, 46);
            passwordText.StateCommon.Back.Color1 = Color.FromArgb(251, 251, 251);
            passwordText.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            passwordText.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            passwordText.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            passwordText.StateCommon.Border.Rounding = 5F;
            passwordText.StateCommon.Border.Width = 1;
            passwordText.StateCommon.Content.Color1 = Color.DimGray;
            passwordText.StateCommon.Content.Font = new Font("Poppins", 10F);
            passwordText.StateCommon.Content.Padding = new Padding(10);
            passwordText.StateDisabled.Back.Color1 = Color.FromArgb(192, 192, 0);
            passwordText.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold);
            label3.Location = new Point(43, 133);
            label3.Name = "label3";
            label3.Size = new Size(223, 37);
            label3.TabIndex = 2;
            label3.Text = "Username or Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold);
            label2.Location = new Point(43, 255);
            label2.Name = "label2";
            label2.Size = new Size(125, 37);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonWrapLabel1);
            kryptonPanel1.Controls.Add(kryptonPictureBox1);
            kryptonPanel1.Controls.Add(kryptonLabel3);
            kryptonPanel1.Controls.Add(kryptonLabel2);
            kryptonPanel1.Location = new Point(527, 13);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Palette = kryptonPalette;
            kryptonPanel1.PaletteMode = PaletteMode.Custom;
            kryptonPanel1.PanelBackStyle = PaletteBackStyle.FormMain;
            kryptonPanel1.Size = new Size(551, 628);
            kryptonPanel1.StateCommon.Color1 = Color.Transparent;
            kryptonPanel1.StateCommon.Color2 = Color.Transparent;
            kryptonPanel1.TabIndex = 2;
            // 
            // kryptonWrapLabel1
            // 
            kryptonWrapLabel1.LabelStyle = LabelStyle.AlternateControl;
            kryptonWrapLabel1.Location = new Point(42, 160);
            kryptonWrapLabel1.Name = "kryptonWrapLabel1";
            kryptonWrapLabel1.Size = new Size(197, 105);
            kryptonWrapLabel1.StateCommon.Font = new Font("Poppins SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonWrapLabel1.StateCommon.TextColor = Color.FromArgb(4, 30, 70);
            kryptonWrapLabel1.Text = resources.GetString("kryptonWrapLabel1.Text");
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.BackgroundImage = Properties.Resources.log;
            kryptonPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            kryptonPictureBox1.Location = new Point(384, 14);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(120, 120);
            kryptonPictureBox1.TabIndex = 22;
            kryptonPictureBox1.TabStop = false;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(25, 512);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(511, 65);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.FromArgb(4, 30, 70);
            kryptonLabel3.StateCommon.ShortText.Color2 = Color.FromArgb(4, 30, 70);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Script MT Bold", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 12;
            kryptonLabel3.Values.Text = "Your health, our priority!";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(44, 14);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(319, 148);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(4, 30, 70);
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.FromArgb(4, 30, 70);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Poppins ExtraBold", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 10;
            kryptonLabel2.Values.Text = "Welcome to \r\nMediTrack!";
            // 
            // buttonSpecAny1
            // 
            buttonSpecAny1.Type = PaletteButtonSpecStyle.FormMin;
            buttonSpecAny1.UniqueName = "589585827dac45bb806e7acd51e4770e";
            // 
            // KLoginView
            // 
            AllowStatusStripMerge = false;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(251, 251, 251);
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ButtonSpecs.Add(buttonSpecAny1);
            ClientSize = new Size(1105, 652);
            Controls.Add(kryptonPanel1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HeaderStyle = HeaderStyle.Custom3;
            Icon = (Icon)resources.GetObject("$this.Icon");
            LocalCustomPalette = kryptonPalette;
            MaximizeBox = false;
            MaximumSize = new Size(1107, 685);
            MinimizeBox = false;
            Name = "KLoginView";
            Padding = new Padding(10);
            PaletteMode = PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Back.Color1 = Color.FromArgb(58, 94, 116);
            StateCommon.Back.Color2 = Color.FromArgb(58, 94, 116);
            StateCommon.Back.GraphicsHint = PaletteGraphicsHint.None;
            StateCommon.Border.Color1 = Color.FromArgb(58, 94, 116);
            StateCommon.Border.Color2 = Color.FromArgb(58, 94, 116);
            StateCommon.Border.Rounding = 5F;
            StateCommon.Border.Width = 1;
            StateCommon.Header.Back.Color1 = Color.FromArgb(4, 70, 87);
            StateCommon.Header.Back.Color2 = Color.FromArgb(58, 94, 116);
            StateCommon.Header.Back.ColorAngle = -45F;
            StateCommon.Header.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            StateCommon.Header.Border.Rounding = 0F;
            StateCommon.Header.Border.Width = -10;
            StateCommon.Header.ButtonEdgeInset = 10;
            StateCommon.Header.Content.AdjacentGap = 5;
            StateCommon.Header.Content.Image.Effect = PaletteImageEffect.LightLight;
            StateCommon.Header.Content.Image.ImageH = PaletteRelativeAlign.Near;
            StateCommon.Header.Content.Padding = new Padding(20, -1, -1, -1);
            StateCommon.Header.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            StateCommon.Header.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            StateCommon.Header.Content.ShortText.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Text = "MediTrack";
            TransparencyKey = Color.Empty;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion



        private KryptonCustomPaletteBase kryptonPalette;
        private KryptonCustomPaletteBase panelPalette;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private KryptonTextBox passwordText;
        private KryptonLabel kryptonLabel1;
        private KryptonLinkLabel signUpLink;
        private KryptonButton loginBtn;
        private KryptonPanel kryptonPanel1;
        private KryptonLabel kryptonLabel2;
        private KryptonWrapLabel kryptonWrapLabel1;
        private KryptonLabel kryptonLabel3;
        private KryptonTextBox usernameText;
        private KryptonPictureBox kryptonPictureBox1;
        private ButtonSpecAny buttonSpecAny1;
    }
}