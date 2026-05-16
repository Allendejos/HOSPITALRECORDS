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
using hrms_client.Views.Dashboard;
using hrms_client.Views.Authentication;
using hrms_query.Session;

namespace hrms_client.Views
{
    public partial class LoginView : KryptonForm, ILoginView
    {
        private bool isSuccessful;
        private string message;
        public LoginView()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
        }
        public void AssociateAndRaiseEvents()
        {
            loginBtn.Click += delegate 
            { 
                LoginEvent?.Invoke(this, EventArgs.Empty);
            };
            signUpLink.Click += delegate { SignUpEvent?.Invoke(this, EventArgs.Empty); };

            //this.FormClosing += (s,e) => FormClosingEvent?.Invoke(this, EventArgs.Empty);
            this.FormClosing += OnFormClosing;



        }

        private void OnFormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !UserSession.IsLoggedIn)
            {
                Application.Exit();
            }
        }


        private void signUpLink_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            SignUpView signUpView = new SignUpView();
            signUpView.Show();
        }

        public void CloseForm() 
        {
            this.Close();
        
        }

        public string UsernameOrEmail
        {
            get => usernameText.Text.Trim();
            set => usernameText.Text = value?.Trim();
        }
        public string Password
        {
            get => passwordText.Text.Trim();
            set => passwordText.Text = value?.Trim();
        }
        public string Token
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
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
        public ILoginPresenter Presenter
        {
            get;
            set;
        }

        public event EventHandler LoginEvent;
        public event EventHandler SignUpEvent;

    }
}
