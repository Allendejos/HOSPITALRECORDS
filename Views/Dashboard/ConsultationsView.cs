using hrms_client.Presenters.Interface;
using hrms_client.Views.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace hrms_client.Views.Dashboard
{
    public partial class ConsultationsView : KryptonForm
    {
        private bool isSuccessful;
        private string message;
        public ConsultationsView()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
            this.FormClosed += KLoginView_FormClosed; // Attach event handler

        }

        private void KLoginView_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void AssociateAndRaiseEvents()
        {
            //loginBtn.Click += delegate { LoginEvent?.Invoke(this, EventArgs.Empty); };
            //signUpLink.Click += delegate { SignUpEvent?.Invoke(this, EventArgs.Empty); };
        }

        private void consultDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Check if the clicked cell is in the "actions" column
                if (consultDataGridView.Columns[e.ColumnIndex].Name == "actions")
                {
                    string patientName = consultDataGridView.Rows[e.RowIndex].Cells["patient_name"].Value?.ToString();
                    MessageBox.Show($"Viewing details for: {patientName}", "Patient Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
