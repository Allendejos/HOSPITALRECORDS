namespace hrms_client.Views.Dashboard
{
    partial class PatientDetailPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DetailsContainer = new Krypton.Toolkit.KryptonPanel();
            UpdatePatientDetailsBtn = new Krypton.Toolkit.KryptonButton();
            ViewPatientDetailsBtn = new Krypton.Toolkit.KryptonButton();
            PatientMiddleName = new Krypton.Toolkit.KryptonLabel();
            PatientFirstName = new Krypton.Toolkit.KryptonLabel();
            PatientLastName = new Krypton.Toolkit.KryptonLabel();
            PatientId = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)DetailsContainer).BeginInit();
            DetailsContainer.SuspendLayout();
            SuspendLayout();
            // 
            // DetailsContainer
            // 
            DetailsContainer.Controls.Add(UpdatePatientDetailsBtn);
            DetailsContainer.Controls.Add(ViewPatientDetailsBtn);
            DetailsContainer.Controls.Add(PatientMiddleName);
            DetailsContainer.Controls.Add(PatientFirstName);
            DetailsContainer.Controls.Add(PatientLastName);
            DetailsContainer.Controls.Add(PatientId);
            DetailsContainer.Dock = DockStyle.Fill;
            DetailsContainer.Location = new Point(0, 0);
            DetailsContainer.Name = "DetailsContainer";
            DetailsContainer.Size = new Size(890, 70);
            DetailsContainer.StateCommon.Color1 = Color.FromArgb(210, 225, 237);
            DetailsContainer.StateCommon.Color2 = Color.FromArgb(210, 225, 237);
            DetailsContainer.TabIndex = 0;
            // 
            // UpdatePatientDetailsBtn
            // 
            UpdatePatientDetailsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UpdatePatientDetailsBtn.Location = new Point(773, 23);
            UpdatePatientDetailsBtn.Name = "UpdatePatientDetailsBtn";
            UpdatePatientDetailsBtn.Size = new Size(90, 25);
            UpdatePatientDetailsBtn.TabIndex = 5;
            UpdatePatientDetailsBtn.Values.DropDownArrowColor = Color.Empty;
            UpdatePatientDetailsBtn.Values.Text = "Update";
            // 
            // ViewPatientDetailsBtn
            // 
            ViewPatientDetailsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ViewPatientDetailsBtn.Location = new Point(677, 23);
            ViewPatientDetailsBtn.Name = "ViewPatientDetailsBtn";
            ViewPatientDetailsBtn.Size = new Size(90, 25);
            ViewPatientDetailsBtn.TabIndex = 4;
            ViewPatientDetailsBtn.Values.DropDownArrowColor = Color.Empty;
            ViewPatientDetailsBtn.Values.Text = "View";
            // 
            // PatientMiddleName
            // 
            PatientMiddleName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PatientMiddleName.Location = new Point(471, 23);
            PatientMiddleName.Name = "PatientMiddleName";
            PatientMiddleName.Size = new Size(123, 27);
            PatientMiddleName.StateCommon.ShortText.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            PatientMiddleName.TabIndex = 3;
            PatientMiddleName.Values.Text = "Middle Name";
            // 
            // PatientFirstName
            // 
            PatientFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PatientFirstName.Location = new Point(290, 23);
            PatientFirstName.Name = "PatientFirstName";
            PatientFirstName.Size = new Size(102, 27);
            PatientFirstName.StateCommon.ShortText.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            PatientFirstName.TabIndex = 2;
            PatientFirstName.Values.Text = "First Name";
            // 
            // PatientLastName
            // 
            PatientLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PatientLastName.Location = new Point(132, 23);
            PatientLastName.Name = "PatientLastName";
            PatientLastName.Size = new Size(101, 27);
            PatientLastName.StateCommon.ShortText.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            PatientLastName.TabIndex = 1;
            PatientLastName.Values.Text = "Last Name";
            // 
            // PatientId
            // 
            PatientId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PatientId.Location = new Point(25, 23);
            PatientId.Name = "PatientId";
            PatientId.Size = new Size(28, 27);
            PatientId.StateCommon.ShortText.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            PatientId.TabIndex = 0;
            PatientId.Values.Text = "Id";
            // 
            // PatientDetailPanel
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(DetailsContainer);
            Name = "PatientDetailPanel";
            Size = new Size(890, 70);
            ((System.ComponentModel.ISupportInitialize)DetailsContainer).EndInit();
            DetailsContainer.ResumeLayout(false);
            DetailsContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel DetailsContainer;
        public Krypton.Toolkit.KryptonLabel PatientFirstName;
        public Krypton.Toolkit.KryptonLabel PatientLastName;
        public Krypton.Toolkit.KryptonLabel PatientId;
        public Krypton.Toolkit.KryptonButton UpdatePatientDetailsBtn;
        public Krypton.Toolkit.KryptonButton ViewPatientDetailsBtn;
        public Krypton.Toolkit.KryptonLabel PatientMiddleName;
    }
}
