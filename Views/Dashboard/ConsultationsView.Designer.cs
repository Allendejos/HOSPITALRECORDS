using Krypton.Toolkit;

namespace hrms_client.Views.Dashboard
{
    partial class ConsultationsView

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultationsView));
            Pallete1 = new KryptonCustomPaletteBase(components);
            Records = new KryptonButton();
            mainPanel = new KryptonPanel();
            kryptonPanel2 = new KryptonPanel();
            kryptonPanel3 = new KryptonPanel();
            dataPanelView = new KryptonPanel();
            consultDataGridView = new KryptonDataGridView();
            patient_id = new KryptonDataGridViewTextBoxColumn();
            patient_name = new KryptonDataGridViewTextBoxColumn();
            consult_date = new KryptonDataGridViewDateTimePickerColumn();
            consult_status = new KryptonDataGridViewTextBoxColumn();
            consult_type = new KryptonDataGridViewTextBoxColumn();
            generateQRBtn = new KryptonDataGridViewButtonColumn();
            headerPanelView = new KryptonPanel();
            filterBtn = new KryptonButton();
            addConsultationBtn = new KryptonButton();
            searchBoxText = new KryptonTextBox();
            searchBtn = new ButtonSpecAny();
            kryptonPanel1 = new KryptonPanel();
            tabTitle = new KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)mainPanel).BeginInit();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataPanelView).BeginInit();
            dataPanelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)consultDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)headerPanelView).BeginInit();
            headerPanelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
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
            Records.Values.Text = "Records";
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(kryptonPanel2);
            mainPanel.Controls.Add(kryptonPanel1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.MaximumSize = new Size(916, 650);
            mainPanel.MinimumSize = new Size(916, 650);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(916, 650);
            mainPanel.StateCommon.Color1 = Color.Transparent;
            mainPanel.StateCommon.Color2 = Color.Transparent;
            mainPanel.StateCommon.ImageStyle = PaletteImageStyle.Stretch;
            mainPanel.TabIndex = 0;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(kryptonPanel3);
            kryptonPanel2.Dock = DockStyle.Fill;
            kryptonPanel2.Location = new Point(0, 63);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Padding = new Padding(20);
            kryptonPanel2.Size = new Size(916, 587);
            kryptonPanel2.StateCommon.Color1 = Color.Transparent;
            kryptonPanel2.StateCommon.Color2 = Color.Transparent;
            kryptonPanel2.TabIndex = 1;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(dataPanelView);
            kryptonPanel3.Dock = DockStyle.Fill;
            kryptonPanel3.Location = new Point(20, 20);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(876, 547);
            kryptonPanel3.StateCommon.Color1 = Color.Transparent;
            kryptonPanel3.StateCommon.Color2 = Color.Transparent;
            kryptonPanel3.StateCommon.ColorAngle = -45F;
            kryptonPanel3.StateCommon.ColorStyle = PaletteColorStyle.Linear33;
            kryptonPanel3.TabIndex = 0;
            // 
            // dataPanelView
            // 
            dataPanelView.Controls.Add(consultDataGridView);
            dataPanelView.Controls.Add(headerPanelView);
            dataPanelView.Dock = DockStyle.Fill;
            dataPanelView.Location = new Point(0, 0);
            dataPanelView.Name = "dataPanelView";
            dataPanelView.Size = new Size(876, 547);
            dataPanelView.StateCommon.Color1 = Color.Transparent;
            dataPanelView.StateCommon.Color2 = Color.Transparent;
            dataPanelView.TabIndex = 1;
            // 
            // consultDataGridView
            // 
            consultDataGridView.AllowUserToDeleteRows = false;
            consultDataGridView.AllowUserToResizeColumns = false;
            consultDataGridView.AllowUserToResizeRows = false;
            consultDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            consultDataGridView.BorderStyle = BorderStyle.None;
            consultDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            consultDataGridView.Columns.AddRange(new DataGridViewColumn[] { patient_id, patient_name, consult_date, consult_status, consult_type, generateQRBtn });
            consultDataGridView.Dock = DockStyle.Fill;
            consultDataGridView.GridStyles.Style = DataGridViewStyle.Mixed;
            consultDataGridView.GridStyles.StyleColumn = GridStyle.Sheet;
            consultDataGridView.GridStyles.StyleDataCells = GridStyle.Sheet;
            consultDataGridView.GridStyles.StyleRow = GridStyle.Sheet;
            consultDataGridView.Location = new Point(0, 77);
            consultDataGridView.MaximumSize = new Size(1067, 472);
            consultDataGridView.Name = "consultDataGridView";
            consultDataGridView.RowHeadersVisible = false;
            consultDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            consultDataGridView.RowTemplate.Height = 40;
            consultDataGridView.ScrollBars = ScrollBars.Horizontal;
            consultDataGridView.Size = new Size(876, 470);
            consultDataGridView.StateCommon.Background.Color1 = Color.FromArgb(252, 252, 252);
            consultDataGridView.StateCommon.Background.Color2 = Color.WhiteSmoke;
            consultDataGridView.StateCommon.Background.ColorAngle = -50F;
            consultDataGridView.StateCommon.Background.ColorStyle = PaletteColorStyle.Linear25;
            consultDataGridView.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundList;
            consultDataGridView.StateCommon.DataCell.Back.Color1 = Color.Transparent;
            consultDataGridView.StateCommon.DataCell.Back.Color2 = Color.Transparent;
            consultDataGridView.StateCommon.DataCell.Border.Color1 = Color.Transparent;
            consultDataGridView.StateCommon.DataCell.Border.Color2 = Color.Transparent;
            consultDataGridView.StateCommon.DataCell.Border.Draw = InheritBool.True;
            consultDataGridView.StateCommon.DataCell.Border.DrawBorders = PaletteDrawBorders.Bottom;
            consultDataGridView.StateCommon.DataCell.Border.Width = 1;
            consultDataGridView.StateCommon.DataCell.Content.Color1 = Color.FromArgb(4, 70, 87);
            consultDataGridView.StateCommon.DataCell.Content.Color2 = Color.FromArgb(4, 70, 87);
            consultDataGridView.StateCommon.DataCell.Content.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            consultDataGridView.StateCommon.DataCell.Content.Padding = new Padding(2);
            consultDataGridView.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(4, 70, 87);
            consultDataGridView.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(4, 70, 87);
            consultDataGridView.StateCommon.HeaderColumn.Border.Color1 = Color.Transparent;
            consultDataGridView.StateCommon.HeaderColumn.Border.Color2 = Color.Transparent;
            consultDataGridView.StateCommon.HeaderColumn.Border.Draw = InheritBool.False;
            consultDataGridView.StateCommon.HeaderColumn.Border.Width = 0;
            consultDataGridView.StateCommon.HeaderColumn.Content.Color1 = Color.FromArgb(251, 252, 252);
            consultDataGridView.StateCommon.HeaderColumn.Content.Color2 = Color.FromArgb(251, 252, 252);
            consultDataGridView.StateCommon.HeaderColumn.Content.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            consultDataGridView.StateCommon.HeaderColumn.Content.Padding = new Padding(5);
            consultDataGridView.StatePressed.HeaderColumn.Back.Color1 = Color.Transparent;
            consultDataGridView.StatePressed.HeaderColumn.Back.Color2 = Color.Transparent;
            consultDataGridView.StatePressed.HeaderColumn.Content.Color1 = Color.FromArgb(4, 70, 87);
            consultDataGridView.StatePressed.HeaderColumn.Content.Color2 = Color.FromArgb(4, 70, 87);
            consultDataGridView.TabIndex = 5;
            // 
            // patient_id
            // 
            patient_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            patient_id.Frozen = true;
            patient_id.HeaderText = "Id";
            patient_id.MinimumWidth = 100;
            patient_id.Name = "patient_id";
            patient_id.ReadOnly = true;
            patient_id.Resizable = DataGridViewTriState.False;
            patient_id.ToolTipText = "Patient Id";
            patient_id.Width = 125;
            // 
            // patient_name
            // 
            patient_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            patient_name.FillWeight = 200F;
            patient_name.HeaderText = "Patient Name";
            patient_name.MinimumWidth = 100;
            patient_name.Name = "patient_name";
            patient_name.ReadOnly = true;
            patient_name.Resizable = DataGridViewTriState.False;
            patient_name.ToolTipText = "Patient Name";
            // 
            // consult_date
            // 
            consult_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            consult_date.Checked = false;
            consult_date.HeaderText = "Date";
            consult_date.MinimumWidth = 6;
            consult_date.Name = "consult_date";
            consult_date.ReadOnly = true;
            consult_date.Resizable = DataGridViewTriState.False;
            consult_date.SortMode = DataGridViewColumnSortMode.Automatic;
            consult_date.ToolTipText = "Consultation Date";
            consult_date.Width = 150;
            // 
            // consult_status
            // 
            consult_status.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            consult_status.HeaderText = "Status";
            consult_status.MinimumWidth = 6;
            consult_status.Name = "consult_status";
            consult_status.ReadOnly = true;
            consult_status.Resizable = DataGridViewTriState.False;
            consult_status.ToolTipText = "Consultation Status";
            consult_status.Width = 150;
            // 
            // consult_type
            // 
            consult_type.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            consult_type.HeaderText = "Type";
            consult_type.MinimumWidth = 6;
            consult_type.Name = "consult_type";
            consult_type.ReadOnly = true;
            consult_type.Resizable = DataGridViewTriState.False;
            consult_type.ToolTipText = "Consultation Type";
            consult_type.Width = 150;
            // 
            // generateQRBtn
            // 
            generateQRBtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            generateQRBtn.ButtonStyle = ButtonStyle.ButtonSpec;
            generateQRBtn.HeaderText = "Action";
            generateQRBtn.MinimumWidth = 6;
            generateQRBtn.Name = "generateQRBtn";
            generateQRBtn.ReadOnly = true;
            generateQRBtn.Resizable = DataGridViewTriState.False;
            generateQRBtn.Text = "Generate QR";
            generateQRBtn.ToolTipText = "Generate QR Code";
            generateQRBtn.UseColumnTextForButtonValue = true;
            generateQRBtn.Width = 150;
            // 
            // headerPanelView
            // 
            headerPanelView.Controls.Add(filterBtn);
            headerPanelView.Controls.Add(addConsultationBtn);
            headerPanelView.Controls.Add(searchBoxText);
            headerPanelView.Dock = DockStyle.Top;
            headerPanelView.Location = new Point(0, 0);
            headerPanelView.Name = "headerPanelView";
            headerPanelView.PanelBackStyle = PaletteBackStyle.PanelCustom1;
            headerPanelView.Size = new Size(876, 77);
            headerPanelView.StateCommon.Color1 = Color.Transparent;
            headerPanelView.StateCommon.Color2 = Color.Transparent;
            headerPanelView.TabIndex = 0;
            // 
            // filterBtn
            // 
            filterBtn.DropDownPosition = VisualOrientation.Bottom;
            filterBtn.Location = new Point(750, 13);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(130, 47);
            filterBtn.TabIndex = 2;
            filterBtn.Values.DropDownArrowColor = Color.Empty;
            filterBtn.Values.Text = "Filter";
            // 
            // addConsultationBtn
            // 
            addConsultationBtn.Location = new Point(489, 13);
            addConsultationBtn.Name = "addConsultationBtn";
            addConsultationBtn.OverrideDefault.Back.Color1 = Color.FromArgb(19, 195, 25);
            addConsultationBtn.OverrideDefault.Back.Color2 = Color.FromArgb(19, 195, 25);
            addConsultationBtn.OverrideDefault.Border.Color1 = Color.Transparent;
            addConsultationBtn.OverrideDefault.Border.Color2 = Color.Transparent;
            addConsultationBtn.OverrideDefault.Border.Rounding = 10F;
            addConsultationBtn.OverrideDefault.Content.AdjacentGap = 5;
            addConsultationBtn.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(252, 252, 252);
            addConsultationBtn.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(252, 252, 252);
            addConsultationBtn.OverrideDefault.Content.ShortText.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addConsultationBtn.Size = new Size(240, 47);
            addConsultationBtn.StateTracking.Back.Color1 = Color.FromArgb(25, 225, 40);
            addConsultationBtn.StateTracking.Back.Color2 = Color.FromArgb(25, 225, 40);
            addConsultationBtn.StateTracking.Border.Color1 = Color.Transparent;
            addConsultationBtn.StateTracking.Border.Color2 = Color.Transparent;
            addConsultationBtn.StateTracking.Border.Rounding = 10F;
            addConsultationBtn.StateTracking.Content.AdjacentGap = 5;
            addConsultationBtn.StateTracking.Content.ShortText.Color1 = Color.FromArgb(252, 252, 252);
            addConsultationBtn.StateTracking.Content.ShortText.Color2 = Color.FromArgb(252, 252, 252);
            addConsultationBtn.StateTracking.Content.ShortText.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addConsultationBtn.TabIndex = 3;
            addConsultationBtn.Values.DropDownArrowColor = Color.Empty;
            addConsultationBtn.Values.Text = "Add Consultation";
            // 
            // searchBoxText
            // 
            searchBoxText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchBoxText.ButtonSpecs.Add(searchBtn);
            searchBoxText.CueHint.Color1 = Color.DarkGray;
            searchBoxText.CueHint.CueHintText = "Search Patient Here...";
            searchBoxText.CueHint.Font = new Font("Poppins Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBoxText.Cursor = Cursors.IBeam;
            searchBoxText.Location = new Point(0, 13);
            searchBoxText.Name = "searchBoxText";
            searchBoxText.ShortcutsEnabled = false;
            searchBoxText.Size = new Size(464, 47);
            searchBoxText.StateActive.Border.Color1 = Color.FromArgb(4, 70, 87);
            searchBoxText.StateActive.Border.Color2 = Color.FromArgb(4, 70, 87);
            searchBoxText.StateActive.Border.Rounding = 10F;
            searchBoxText.StateActive.Content.Color1 = Color.FromArgb(4, 70, 87);
            searchBoxText.StateActive.Content.Font = new Font("Poppins Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBoxText.StateCommon.Border.Color1 = Color.Transparent;
            searchBoxText.StateCommon.Border.Color2 = Color.Transparent;
            searchBoxText.StateCommon.Border.Rounding = 10F;
            searchBoxText.StateCommon.Content.Color1 = Color.DimGray;
            searchBoxText.StateCommon.Content.Font = new Font("Poppins Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBoxText.StateCommon.Content.Padding = new Padding(10, 5, 5, 5);
            searchBoxText.StateCommon.Content.TextH = PaletteRelativeAlign.Center;
            searchBoxText.StateDisabled.Back.Color1 = Color.LightGray;
            searchBoxText.StateDisabled.Border.Color1 = Color.Gray;
            searchBoxText.StateDisabled.Border.Color2 = Color.Gray;
            searchBoxText.StateDisabled.Content.Color1 = Color.Gray;
            searchBoxText.StateDisabled.Content.Font = new Font("Poppins Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBoxText.StateNormal.Border.Color1 = Color.LightGray;
            searchBoxText.StateNormal.Border.Color2 = Color.LightGray;
            searchBoxText.StateNormal.Border.Rounding = 10F;
            searchBoxText.StateNormal.Content.Color1 = Color.DimGray;
            searchBoxText.StateNormal.Content.Font = new Font("Poppins Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBoxText.TabIndex = 0;
            searchBoxText.WordWrap = false;
            // 
            // searchBtn
            // 
            searchBtn.ColorMap = Color.Transparent;
            searchBtn.Edge = PaletteRelativeEdgeAlign.Far;
            searchBtn.ImageTransparentColor = Color.Transparent;
            searchBtn.UniqueName = "af119e4534774ee78bc77fbe45a10b21";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(tabTitle);
            kryptonPanel1.Dock = DockStyle.Top;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(916, 63);
            kryptonPanel1.StateCommon.Color1 = Color.Transparent;
            kryptonPanel1.StateCommon.Color2 = Color.Transparent;
            kryptonPanel1.TabIndex = 0;
            // 
            // tabTitle
            // 
            tabTitle.Location = new Point(20, 20);
            tabTitle.Name = "tabTitle";
            tabTitle.Size = new Size(317, 43);
            tabTitle.StateCommon.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            tabTitle.StateCommon.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            tabTitle.StateCommon.ShortText.Font = new Font("Poppins SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabTitle.TabIndex = 0;
            tabTitle.Values.Text = "Patient Consultations";
            // 
            // ConsultationsView
            // 
            AllowStatusStripMerge = false;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(251, 251, 251);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(916, 648);
            Controls.Add(mainPanel);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            HeaderStyle = HeaderStyle.Custom3;
            Icon = (Icon)resources.GetObject("$this.Icon");
            LocalCustomPalette = Pallete1;
            MaximizeBox = false;
            MaximumSize = new Size(916, 650);
            MinimizeBox = false;
            MinimumSize = new Size(916, 650);
            Name = "ConsultationsView";
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
            TransparencyKey = Color.Empty;
            ((System.ComponentModel.ISupportInitialize)mainPanel).EndInit();
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataPanelView).EndInit();
            dataPanelView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)consultDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)headerPanelView).EndInit();
            headerPanelView.ResumeLayout(false);
            headerPanelView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private KryptonCustomPaletteBase Pallete1;
        private KryptonButton Records;
        private KryptonPanel mainPanel;
        private KryptonPanel kryptonPanel2;
        private KryptonPanel kryptonPanel3;
        private KryptonPanel kryptonPanel1;
        private KryptonPanel dataPanelView;
        private KryptonTextBox searchBoxText;
        private ButtonSpecAny searchBtn;
        private KryptonButton addConsultationBtn;
        private KryptonPanel headerPanelView;
        private KryptonLabel tabTitle;
        private KryptonButton filterBtn;
        private KryptonDataGridView consultDataGridView;
        private KryptonDataGridViewTextBoxColumn patient_id;
        private KryptonDataGridViewTextBoxColumn patient_name;
        private KryptonDataGridViewDateTimePickerColumn consult_date;
        private KryptonDataGridViewTextBoxColumn consult_status;
        private KryptonDataGridViewTextBoxColumn consult_type;
        private KryptonDataGridViewButtonColumn generateQRBtn;
    }
}