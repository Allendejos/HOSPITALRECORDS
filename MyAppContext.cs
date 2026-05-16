using hrms_client.Views.Interface;
using hrms_query.Database;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hrms_client
{
    public class MyAppContext : ApplicationContext, IAppContext
    {
        public MyAppContext(KryptonForm mainForm) : base(mainForm)
        {
             //Optional: You can add any additional initialization here
        }

        public void SwitchMainForm(KryptonForm newMainForm)
        {
            // Set the new main form
            KryptonForm oldMainForm = (KryptonForm)MainForm;
            MainForm = newMainForm;

            // Show the new form and hide the old one
            newMainForm.Show();

            // Close the old form - this won't exit the application
            // because we've already set the new main form
            oldMainForm.Close();
        }
    }
}
