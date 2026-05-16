using hrms_client.Views.Dashboard;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Krypton.Toolkit.ColorHelper;

namespace hrms_client.Views
{
    public partial class ConsultationViewjn : Form
    {
        private static ConsultationViewjn instance;
        public ConsultationViewjn()
        {
            InitializeComponent();
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public static ConsultationViewjn GetInstance(KryptonPanel panelContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ConsultationViewjn();
                instance.TopLevel = false;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(instance);
                instance.Show();
                instance.PerformLayout();
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;

                instance.BringToFront();
            }
            return instance;
        }
        private void SetButtonColor(KryptonButton button, Color color)
        {
            button.OverrideDefault.Back.Color1 = color;
            button.OverrideDefault.Back.Color2 = color;
            button.StateCommon.Back.Color1 = color;
            button.StateCommon.Back.Color2 = color;
        }
        private void allButton_Click(object sender, EventArgs e)
        {
            filterDropdown.Text = "All";
            Color allColor = Color.FromArgb(58, 94, 116);
            Color grayColor = Color.FromArgb(163, 180, 190);

            SetButtonColor(allButton, allColor);
            SetButtonColor(completedButton, grayColor);
            SetButtonColor(scheduledButton, grayColor);
            SetButtonColor(pendingButton, grayColor);
            SetButtonColor(cancelledButton, grayColor);


            flowPanelAll.Visible = true;
            flowPanelCompleted.Visible = false;
            flowPanelScheduled.Visible = false;
            flowPanelPending.Visible = false;
            flowPanelCancel.Visible = false;
        }
        private void completedButton_Click(object sender, EventArgs e)
        {
            filterDropdown.Text = "Completed";
            Color completedColor = Color.FromArgb(19, 195, 51);
            Color grayColor = Color.FromArgb(163, 180, 190);

            SetButtonColor(allButton, grayColor);
            SetButtonColor(completedButton, completedColor);
            SetButtonColor(scheduledButton, grayColor);
            SetButtonColor(pendingButton, grayColor);
            SetButtonColor(cancelledButton, grayColor);


            completedButton.BackColor = Color.Black;
            flowPanelAll.Visible = false;
            flowPanelCompleted.Visible = true;
            flowPanelScheduled.Visible = false;
            flowPanelPending.Visible = false;
            flowPanelCancel.Visible = false;
        }

        private void scheduledButton_Click(object sender, EventArgs e)
        {
            filterDropdown.Text = "Scheduled";
            Color scheduledColor = Color.FromArgb(22, 123, 186);
            Color grayColor = Color.FromArgb(163, 180, 190);

            SetButtonColor(allButton, grayColor);
            SetButtonColor(completedButton, grayColor);
            SetButtonColor(scheduledButton, scheduledColor);
            SetButtonColor(pendingButton, grayColor);
            SetButtonColor(cancelledButton, grayColor);


            flowPanelAll.Visible = false;
            flowPanelCompleted.Visible = false;
            flowPanelScheduled.Visible = true;
            flowPanelPending.Visible = false;
            flowPanelCancel.Visible = false;
        }

        private void pendingButton_Click(object sender, EventArgs e)
        {
            filterDropdown.Text = "Pending";
            Color pendingColor = Color.FromArgb(244, 162, 97);
            Color grayColor = Color.FromArgb(163, 180, 190);

            SetButtonColor(allButton, grayColor);
            SetButtonColor(completedButton, grayColor);
            SetButtonColor(scheduledButton, grayColor);
            SetButtonColor(pendingButton, pendingColor);
            SetButtonColor(cancelledButton, grayColor);

            flowPanelAll.Visible = false;
            flowPanelCompleted.Visible = false;
            flowPanelScheduled.Visible = false;
            flowPanelPending.Visible = true;
            flowPanelCancel.Visible = false;
        }

        private void cancelledButton_Click(object sender, EventArgs e)
        {
            filterDropdown.Text = "Cancelled";
            Color cancelledColor = Color.FromArgb(230, 57, 70);
            Color grayColor = Color.FromArgb(163, 180, 190);

            SetButtonColor(allButton, grayColor);
            SetButtonColor(completedButton, grayColor);
            SetButtonColor(scheduledButton, grayColor);
            SetButtonColor(pendingButton, grayColor);
            SetButtonColor(cancelledButton, cancelledColor);

            flowPanelAll.Visible = false;
            flowPanelCompleted.Visible = false;
            flowPanelScheduled.Visible = false;
            flowPanelPending.Visible = false;
            flowPanelCancel.Visible = true;
        }


        private void filterNames_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            filterDropdown.Text = e.ClickedItem.Text;
            if (filterDropdown.Text == "All")
            {
                allButton_Click(sender, e);        
            }
            else if (filterDropdown.Text == "Completed")
            {
                completedButton_Click(sender, e);
  
            }
            else if (filterDropdown.Text == "Scheduled")
            {
                scheduledButton_Click(sender, e);
              
            }
            else if (filterDropdown.Text == "Pending")
            {
                pendingButton_Click(sender, e);
  
            }
            else if (filterDropdown.Text == "Cancelled")
            {
                cancelledButton_Click(sender, e);

            }
        }

        private void addConsultBTN_MouseClick(object sender, MouseEventArgs e)
        {
            Panel panel1 = new Panel()
            {
                BackColor = Color.FromArgb(210, 225, 237),
                Location = new Point(3, 3),
                Name = "panel1",
                Size = new Size(785, 70),
                TabIndex = 0

            };
            flowPanelAll.Controls.Add(panel1);

            Panel panel2 = new Panel()
            {
                BackColor = Color.FromArgb(210, 225, 237),
                Location = new Point(5, 5),
                Name = "panel2",
                Size = new Size(785, 70),
                TabIndex = 0

            };

            flowPanelPending.Controls.Add(panel2);

        }

        private void addConsultBTN_Click(object sender, EventArgs e)
        {

        }

        private void completedButton_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void flowPanelCompleted_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowPanelAll_Paint(object sender, PaintEventArgs e)
        {

        }

        private void filterDropdown_Click(object sender, EventArgs e)
        {
            if(filterDropdown.Text == "Completed")
            {
                completedButton.PerformClick();
            }
        }
    }
}
