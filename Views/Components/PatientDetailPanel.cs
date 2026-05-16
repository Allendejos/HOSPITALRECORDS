using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hrms_client.Views.Dashboard
{
    public partial class PatientDetailPanel : UserControl
    {
        public event EventHandler UpdateBtnClickEvent;
        public event EventHandler ViewBtnClickEvent;
        public PatientDetailPanel()
        {
            InitializeComponent();

            UpdatePatientDetailsBtn.Click += (s, e) => UpdateBtnClickEvent?.Invoke(s, e);
            ViewPatientDetailsBtn.Click += (s, e) => ViewBtnClickEvent?.Invoke(s, e);

        }
    }
}
