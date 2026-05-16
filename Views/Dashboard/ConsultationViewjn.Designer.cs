namespace hrms_client.Views
{
    partial class ConsultationViewjn
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
            searchPatientTextBox = new Krypton.Toolkit.KryptonTextBox();
            addConsultBTN = new Krypton.Toolkit.KryptonButton();
            flowPanelCompleted = new FlowLayoutPanel();
            flowPanelScheduled = new FlowLayoutPanel();
            panel1 = new Panel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            filterDropdown = new Krypton.Toolkit.KryptonDropButton();
            filterNames = new ContextMenuStrip(components);
            completedToolStripMenuItem = new ToolStripMenuItem();
            scheduledToolStripMenuItem = new ToolStripMenuItem();
            pendingToolStripMenuItem = new ToolStripMenuItem();
            cancelledToolStripMenuItem = new ToolStripMenuItem();
            allToolStripMenuItem = new ToolStripMenuItem();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            flowPanelPending = new FlowLayoutPanel();
            flowPanelCancel = new FlowLayoutPanel();
            flowPanelAll = new FlowLayoutPanel();
            completedButton = new Krypton.Toolkit.KryptonButton();
            pendingButton = new Krypton.Toolkit.KryptonButton();
            cancelledButton = new Krypton.Toolkit.KryptonButton();
            scheduledButton = new Krypton.Toolkit.KryptonButton();
            allButton = new Krypton.Toolkit.KryptonButton();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            panel1.SuspendLayout();
            filterNames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // searchPatientTextBox
            // 
            searchPatientTextBox.CueHint.CueHintText = "Search a patient";
            searchPatientTextBox.CueHint.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchPatientTextBox.Location = new Point(49, 71);
            searchPatientTextBox.Multiline = true;
            searchPatientTextBox.Name = "searchPatientTextBox";
            searchPatientTextBox.Size = new Size(527, 30);
            searchPatientTextBox.StateCommon.Border.Rounding = 7F;
            searchPatientTextBox.TabIndex = 4;
            searchPatientTextBox.TextChanged += kryptonTextBox1_TextChanged;
            // 
            // addConsultBTN
            // 
            addConsultBTN.Cursor = Cursors.Hand;
            addConsultBTN.Location = new Point(588, 71);
            addConsultBTN.Name = "addConsultBTN";
            addConsultBTN.Size = new Size(148, 30);
            addConsultBTN.StateCommon.Back.Color1 = Color.FromArgb(19, 195, 51);
            addConsultBTN.StateCommon.Back.Color2 = Color.FromArgb(19, 195, 51);
            addConsultBTN.StateCommon.Border.Rounding = 6F;
            addConsultBTN.StateCommon.Content.Padding = new Padding(22, -1, -1, -1);
            addConsultBTN.StateCommon.Content.ShortText.Color1 = Color.White;
            addConsultBTN.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addConsultBTN.TabIndex = 5;
            addConsultBTN.Values.DropDownArrowColor = Color.Empty;
            addConsultBTN.Values.Text = "Add Consultation";
            addConsultBTN.Click += addConsultBTN_Click;
            addConsultBTN.MouseClick += addConsultBTN_MouseClick;
            // 
            // flowPanelCompleted
            // 
            flowPanelCompleted.AutoScroll = true;
            flowPanelCompleted.BackColor = Color.Lime;
            flowPanelCompleted.Location = new Point(49, 205);
            flowPanelCompleted.Name = "flowPanelCompleted";
            flowPanelCompleted.Size = new Size(813, 420);
            flowPanelCompleted.TabIndex = 7;
            flowPanelCompleted.Visible = false;
            // 
            // flowPanelScheduled
            // 
            flowPanelScheduled.AutoScroll = true;
            flowPanelScheduled.BackColor = Color.LightSeaGreen;
            flowPanelScheduled.Location = new Point(49, 200);
            flowPanelScheduled.Name = "flowPanelScheduled";
            flowPanelScheduled.Size = new Size(813, 432);
            flowPanelScheduled.TabIndex = 0;
            flowPanelScheduled.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 94, 116);
            panel1.Controls.Add(kryptonLabel6);
            panel1.Controls.Add(kryptonLabel5);
            panel1.Controls.Add(kryptonLabel4);
            panel1.Controls.Add(kryptonLabel3);
            panel1.Controls.Add(kryptonLabel2);
            panel1.Controls.Add(kryptonLabel1);
            panel1.Location = new Point(49, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 49);
            panel1.TabIndex = 8;
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(687, 10);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(62, 25);
            kryptonLabel6.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold);
            kryptonLabel6.TabIndex = 5;
            kryptonLabel6.Values.Text = "Action";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(574, 10);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(50, 25);
            kryptonLabel5.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold);
            kryptonLabel5.TabIndex = 4;
            kryptonLabel5.Values.Text = "Type";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(448, 10);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(62, 25);
            kryptonLabel4.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold);
            kryptonLabel4.TabIndex = 3;
            kryptonLabel4.Values.Text = "Status";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(172, 10);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(67, 25);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold);
            kryptonLabel3.TabIndex = 2;
            kryptonLabel3.Values.Text = "Patient";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(338, 10);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(49, 25);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Date";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(70, 10);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(27, 25);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "ID";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(338, 18);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(265, 38);
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Poppins", 17.25F, FontStyle.Bold);
            kryptonLabel7.TabIndex = 9;
            kryptonLabel7.Values.Text = "Patient Consultation";
            // 
            // filterDropdown
            // 
            filterDropdown.ContextMenuStrip = filterNames;
            filterDropdown.Cursor = Cursors.Hand;
            filterDropdown.Location = new Point(748, 71);
            filterDropdown.Name = "filterDropdown";
            filterDropdown.Size = new Size(114, 30);
            filterDropdown.StateCommon.Back.Color1 = Color.FromArgb(58, 94, 116);
            filterDropdown.StateCommon.Back.Color2 = Color.FromArgb(58, 94, 116);
            filterDropdown.StateCommon.Border.Rounding = 7F;
            filterDropdown.StateCommon.Content.ShortText.Color1 = Color.White;
            filterDropdown.StateCommon.Content.ShortText.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filterDropdown.TabIndex = 10;
            filterDropdown.Values.DropDownArrowColor = Color.Empty;
            filterDropdown.Values.Text = "All";
            filterDropdown.Click += filterDropdown_Click;
            // 
            // filterNames
            // 
            filterNames.Font = new Font("Segoe UI", 9F);
            filterNames.Items.AddRange(new ToolStripItem[] { completedToolStripMenuItem, scheduledToolStripMenuItem, pendingToolStripMenuItem, cancelledToolStripMenuItem, allToolStripMenuItem });
            filterNames.Name = "filterNames";
            filterNames.Size = new Size(134, 114);
            filterNames.ItemClicked += filterNames_ItemClicked;
            // 
            // completedToolStripMenuItem
            // 
            completedToolStripMenuItem.Name = "completedToolStripMenuItem";
            completedToolStripMenuItem.Size = new Size(133, 22);
            completedToolStripMenuItem.Text = "All";
            // 
            // scheduledToolStripMenuItem
            // 
            scheduledToolStripMenuItem.Name = "scheduledToolStripMenuItem";
            scheduledToolStripMenuItem.Size = new Size(133, 22);
            scheduledToolStripMenuItem.Text = "Completed";
            // 
            // pendingToolStripMenuItem
            // 
            pendingToolStripMenuItem.Name = "pendingToolStripMenuItem";
            pendingToolStripMenuItem.Size = new Size(133, 22);
            pendingToolStripMenuItem.Text = "Scheduled";
            // 
            // cancelledToolStripMenuItem
            // 
            cancelledToolStripMenuItem.Name = "cancelledToolStripMenuItem";
            cancelledToolStripMenuItem.Size = new Size(133, 22);
            cancelledToolStripMenuItem.Text = "Pending";
            // 
            // allToolStripMenuItem
            // 
            allToolStripMenuItem.Name = "allToolStripMenuItem";
            allToolStripMenuItem.Size = new Size(133, 22);
            allToolStripMenuItem.Text = "Cancelled";
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            kryptonPictureBox1.Image = Properties.Resources.add24p;
            kryptonPictureBox1.Location = new Point(6, 2);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(17, 17);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            kryptonPictureBox1.TabIndex = 11;
            kryptonPictureBox1.TabStop = false;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(kryptonPictureBox1);
            kryptonPanel2.Location = new Point(590, 75);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(25, 21);
            kryptonPanel2.StateCommon.Color1 = Color.FromArgb(19, 195, 51);
            kryptonPanel2.StateCommon.Color2 = Color.FromArgb(19, 195, 51);
            kryptonPanel2.TabIndex = 12;
            // 
            // flowPanelPending
            // 
            flowPanelPending.AutoScroll = true;
            flowPanelPending.BackColor = Color.Black;
            flowPanelPending.Location = new Point(49, 205);
            flowPanelPending.Name = "flowPanelPending";
            flowPanelPending.Size = new Size(813, 420);
            flowPanelPending.TabIndex = 13;
            flowPanelPending.Visible = false;
            // 
            // flowPanelCancel
            // 
            flowPanelCancel.AutoScroll = true;
            flowPanelCancel.Location = new Point(49, 205);
            flowPanelCancel.Name = "flowPanelCancel";
            flowPanelCancel.Size = new Size(813, 427);
            flowPanelCancel.TabIndex = 14;
            flowPanelCancel.Visible = false;
            // 
            // flowPanelAll
            // 
            flowPanelAll.AutoScroll = true;
            flowPanelAll.BackColor = Color.Maroon;
            flowPanelAll.Location = new Point(49, 200);
            flowPanelAll.Name = "flowPanelAll";
            flowPanelAll.Size = new Size(813, 432);
            flowPanelAll.TabIndex = 15;
            flowPanelAll.Paint += flowPanelAll_Paint;
            // 
            // completedButton
            // 
            completedButton.Cursor = Cursors.Hand;
            completedButton.Location = new Point(172, 5);
            completedButton.Name = "completedButton";
            completedButton.Size = new Size(136, 34);
            completedButton.StateCommon.Back.Color1 = Color.FromArgb(163, 180, 190);
            completedButton.StateCommon.Back.Color2 = Color.FromArgb(163, 180, 190);
            completedButton.StateCommon.Border.Rounding = 5F;
            completedButton.StateCommon.Content.Padding = new Padding(2);
            completedButton.StateCommon.Content.ShortText.Color1 = Color.White;
            completedButton.StateCommon.Content.ShortText.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            completedButton.TabIndex = 0;
            completedButton.Values.DropDownArrowColor = Color.Empty;
            completedButton.Values.Text = "Completed";
            completedButton.Click += completedButton_Click;
            completedButton.MouseClick += completedButton_MouseClick;
            // 
            // pendingButton
            // 
            pendingButton.Cursor = Cursors.Hand;
            pendingButton.Location = new Point(488, 5);
            pendingButton.Name = "pendingButton";
            pendingButton.Size = new Size(136, 34);
            pendingButton.StateCommon.Back.Color1 = Color.FromArgb(163, 180, 190);
            pendingButton.StateCommon.Back.Color2 = Color.FromArgb(163, 180, 190);
            pendingButton.StateCommon.Border.Rounding = 5F;
            pendingButton.StateCommon.Content.ShortText.Color1 = Color.White;
            pendingButton.StateCommon.Content.ShortText.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            pendingButton.TabIndex = 1;
            pendingButton.Values.DropDownArrowColor = Color.Empty;
            pendingButton.Values.Text = "Pending";
            pendingButton.Click += pendingButton_Click;
            pendingButton.MouseClick += completedButton_MouseClick;
            // 
            // cancelledButton
            // 
            cancelledButton.Cursor = Cursors.Hand;
            cancelledButton.Location = new Point(646, 5);
            cancelledButton.Name = "cancelledButton";
            cancelledButton.Size = new Size(136, 34);
            cancelledButton.StateCommon.Back.Color1 = Color.FromArgb(163, 180, 190);
            cancelledButton.StateCommon.Back.Color2 = Color.FromArgb(163, 180, 190);
            cancelledButton.StateCommon.Border.Rounding = 5F;
            cancelledButton.StateCommon.Content.ShortText.Color1 = Color.White;
            cancelledButton.StateCommon.Content.ShortText.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            cancelledButton.TabIndex = 2;
            cancelledButton.Values.DropDownArrowColor = Color.Empty;
            cancelledButton.Values.Text = "Cancelled";
            cancelledButton.Click += cancelledButton_Click;
            cancelledButton.MouseClick += completedButton_MouseClick;
            // 
            // scheduledButton
            // 
            scheduledButton.Cursor = Cursors.Hand;
            scheduledButton.Location = new Point(331, 5);
            scheduledButton.Name = "scheduledButton";
            scheduledButton.Size = new Size(136, 34);
            scheduledButton.StateCommon.Back.Color1 = Color.FromArgb(163, 180, 190);
            scheduledButton.StateCommon.Back.Color2 = Color.FromArgb(163, 180, 190);
            scheduledButton.StateCommon.Border.Rounding = 5F;
            scheduledButton.StateCommon.Content.ShortText.Color1 = Color.White;
            scheduledButton.StateCommon.Content.ShortText.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            scheduledButton.TabIndex = 3;
            scheduledButton.Values.DropDownArrowColor = Color.Empty;
            scheduledButton.Values.Text = "Scheduled";
            scheduledButton.Click += scheduledButton_Click;
            scheduledButton.MouseClick += completedButton_MouseClick;
            // 
            // allButton
            // 
            allButton.Cursor = Cursors.Hand;
            allButton.Location = new Point(79, 124);
            allButton.Name = "allButton";
            allButton.Size = new Size(104, 34);
            allButton.StateCommon.Back.Color1 = Color.FromArgb(58, 94, 116);
            allButton.StateCommon.Back.Color2 = Color.FromArgb(58, 94, 116);
            allButton.StateCommon.Border.Rounding = 5F;
            allButton.StateCommon.Content.Padding = new Padding(2);
            allButton.StateCommon.Content.ShortText.Color1 = Color.White;
            allButton.StateCommon.Content.ShortText.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            allButton.TabIndex = 4;
            allButton.Values.DropDownArrowColor = Color.Empty;
            allButton.Values.Text = "All";
            allButton.Click += allButton_Click;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(cancelledButton);
            kryptonPanel1.Controls.Add(completedButton);
            kryptonPanel1.Controls.Add(pendingButton);
            kryptonPanel1.Controls.Add(scheduledButton);
            kryptonPanel1.Location = new Point(49, 119);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(813, 44);
            kryptonPanel1.StateCommon.Color1 = Color.White;
            kryptonPanel1.TabIndex = 16;
            // 
            // ConsultationViewjn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_signUp;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(916, 688);
            Controls.Add(allButton);
            Controls.Add(kryptonPanel1);
            Controls.Add(flowPanelAll);
            Controls.Add(flowPanelScheduled);
            Controls.Add(flowPanelCancel);
            Controls.Add(flowPanelPending);
            Controls.Add(kryptonPanel2);
            Controls.Add(filterDropdown);
            Controls.Add(kryptonLabel7);
            Controls.Add(panel1);
            Controls.Add(flowPanelCompleted);
            Controls.Add(addConsultBTN);
            Controls.Add(searchPatientTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConsultationViewjn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultationViewjn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            filterNames.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Krypton.Toolkit.KryptonTextBox searchPatientTextBox;
        private Krypton.Toolkit.KryptonButton addConsultBTN;
        private FlowLayoutPanel flowPanelCompleted;
        private Panel panel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonDropButton filterDropdown;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ContextMenuStrip filterNames;
        private ToolStripMenuItem completedToolStripMenuItem;
        private ToolStripMenuItem scheduledToolStripMenuItem;
        private ToolStripMenuItem pendingToolStripMenuItem;
        private ToolStripMenuItem cancelledToolStripMenuItem;
        private FlowLayoutPanel flowPanelScheduled;
        private FlowLayoutPanel flowPanelPending;
        private FlowLayoutPanel flowPanelCancel;
        private FlowLayoutPanel flowPanelAll;
        private Krypton.Toolkit.KryptonButton completedButton;
        private Krypton.Toolkit.KryptonButton pendingButton;
        private Krypton.Toolkit.KryptonButton cancelledButton;
        private Krypton.Toolkit.KryptonButton scheduledButton;
        private Krypton.Toolkit.KryptonButton allButton;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ToolStripMenuItem allToolStripMenuItem;
    }
}