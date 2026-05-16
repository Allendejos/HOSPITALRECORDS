using hrms_client.Views.Interface;
using hrms_client.Presenters.Interface;
using hrms_query.Models;
using hrms_query.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hrms_client.Views.Dashboard;
using Krypton.Toolkit;

namespace hrms_client.Views
{
    public partial class RegisterView : Form, IRegisterView
    {
        private string message, token;
        private bool isSuccessful, isErrorful, isRegistering;
        private static RegisterView instance;


        public RegisterView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }
        private void AssociateAndRaiseViewEvents()
        {
            registerBtn.Click += delegate { RegisterEvent?.Invoke(this, EventArgs.Empty); };
            cancelBtn.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };

        }

        public void SetSpecializationBindingSource(BindingSource specializationList)
        {
            specializationOptions.DataSource = specializationList;
        }

        public void SetRoleBindingSource(BindingSource roleList)
        {
            positionOptions.DataSource = roleList;
        }

        public void SetGenderBindingSource(BindingSource genderList)
        {
            genderOptions.DataSource = genderList;
        }

        private void userNameText_TextChanged(object sender, EventArgs e)
        {

        }

        public static RegisterView GetInstance(KryptonPanel panelContainer) 
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new RegisterView();
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



        public IRegisterPresenter Presenter { get; set; }

        public string Username
        {
            get => userNameText.Text.Trim();
            set => userNameText.Text = value?.Trim();
        }

        public string Password
        {
            get => passwordText.Text.Trim();
            set => passwordText.Text = value?.Trim();
        }

        public string ConfirmPassword
        {
            get => confirmPassText.Text.Trim();
            set => confirmPassText.Text = value?.Trim();
        }

        public string Email
        {
            get => emailText.Text.Trim();
            set => emailText.Text = value?.Trim();
        }

        public string FirstName
        {
            get => firstNameText.Text.Trim();
            set => firstNameText.Text = value?.Trim();
        }

        public string LastName
        {
            get => lastNameText.Text.Trim();
            set => lastNameText.Text = value?.Trim();
        }

        public string MiddleName
        {
            get => middleNameText.Text.Trim();
            set => middleNameText.Text = value?.Trim();
        }

        public string ContactNumber
        {
            get => contactNumText.Text.Trim();
            set => contactNumText.Text = value?.Trim();
        }

        public string MedLicense
        {
            get => medLicenseText.Text.Trim();
            set => medLicenseText.Text = value?.Trim();
        }

        public int? SelectedSpecializationIndex
        {
            get => specializationOptions.SelectedIndex >= 0 ? specializationOptions.SelectedIndex : (int?)null;
            set => specializationOptions.SelectedIndex = value ?? -1;
        }

        public int? SelectedRoleIndex
        {
            get => positionOptions.SelectedIndex >= 0 ? positionOptions.SelectedIndex : (int?)null;
            set => positionOptions.SelectedIndex = value ?? -1;
        }

        public int? SelectedGenderIndex
        {
            get => genderOptions.SelectedIndex >= 0 ? genderOptions.SelectedIndex : (int?)null;
            set => genderOptions.SelectedIndex = value ?? -1;
        }
        public string Token
        {
            get => token;
            set => token = value;
        }
        public Gender? Gender
        {
            get => genderOptions.SelectedItem is Gender gender ? gender : null;
            set => genderOptions.SelectedItem = value is Gender gnd ? gnd : null;
        }
        public Specialization? Specialization
        {
            get => specializationOptions.SelectedItem is Specialization specialization ? specialization : null;
            set => specializationOptions.SelectedItem = value is Specialization sp ? sp : null;
        }
        public Role? Role
        {
            get => positionOptions.SelectedItem is Role role ? role : null;
            set => positionOptions.SelectedItem = value is Role role ? role : null;
        }
        public bool IsSuccessful
        {
            get => isSuccessful;
            set => isSuccessful = value;
        }
        public string Message
        {
            get => message;
            set => message = value;
        }
        public bool IsErrorful
        {
            get => isErrorful;
            set => isErrorful = value;
        }
        public bool IsRegistering
        {
            get => IsRegistering;
            set => isRegistering = value;
        }


        public event EventHandler RegisterEvent;
        public event EventHandler CancelEvent;
    }
}
