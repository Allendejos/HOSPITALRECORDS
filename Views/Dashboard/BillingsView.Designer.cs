using Krypton.Toolkit;

namespace hrms_client.Views.Dashboard
{
    partial class AppointmentView

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentView));
            SuspendLayout();
            // 
            // AppointmentView
            // 
            AllowStatusStripMerge = false;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(251, 251, 251);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1109, 655);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HeaderStyle = HeaderStyle.Custom3;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1109, 688);
            MinimizeBox = false;
            MinimumSize = new Size(1109, 688);
            Name = "AppointmentView";
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
            ResumeLayout(false);
        }

        #endregion
    }
}