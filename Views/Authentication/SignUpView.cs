using hrms_client.Views.Interface;
using Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace hrms_client.Views
{
    public partial class SignUpView : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private int progressTarget = 0;

        public int continueButton = 0;
        public int RegisterButton = 0;
        public int BackButton = 0;


        public SignUpView()
        {
            InitializeComponent();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
        }

        private void InitializeProgressBar()
        {
            kryptonProgressBar1 = new KryptonProgressBar
            {
                Minimum = 10,
                Maximum = 100,
                Value = 0,
                Style = ProgressBarStyle.Continuous
            };


            this.Controls.Add(kryptonProgressBar1);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (kryptonProgressBar1.Value < progressTarget)
            {
                kryptonProgressBar1.Value += 2; // Smooth Increment
            }
            else if (kryptonProgressBar1.Value > progressTarget)
            {
                kryptonProgressBar1.Value -= 2;
            }
            else
            {
                timer.Stop();
            }
        }
        private void SmoothProgress(int targetValue)
        {
            progressTarget = targetValue; // Set the target value

            timer.Start();
        }

        //value for position/role
        private void contextRole_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

            RoleTextBox.Text = e.ClickedItem.Text;
            //MessageBox.Show("Selected: " + e.ClickedItem.Text);
        }


        //continue button
        private void ContinueButton_Click(object sender, EventArgs e)
        {
            if (usernameTxtBox.Text == "" || passwordTextBox.Text == "" || confirmPassword.Text == "" || emailTextBox.Text == "" || RoleTextBox.Text == "")
            {
                MessageBox.Show("Please enter all fields");
            }
            else if (passwordTextBox.Text != confirmPassword.Text)
            {
                MessageBox.Show("Password does not match. Please try again");
            }
            else
            {
                signUpPart1.Hide();
                signUpPart2.Show();
                signUpPart2.Visible = true;
                continueButton++;
                RegisterButton++;

                if (continueButton == 1)
                {
                    SmoothProgress(kryptonProgressBar1.Maximum / 2);
                }
                else if (RegisterButton == 2)
                {
                    SmoothProgress(kryptonProgressBar1.Maximum);

                }
                //MessageBox.Show($"Username: {usernameTxtBox.Text}\nConfirm Password: {confirmPassword.Text}\nEmail: {emailTextBox.Text} \nRole: {RoleTextBox.Text}");
            }
        }

        //register button
        private void registerButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || contactNumTextBox.Text == "" || sexTextBox.Text == "" || specializationTextBox.Text == "" || birthdayTextBox.Text == "" || licenseTextBox.Text == "")
            {
                MessageBox.Show("Please enter all fields");
            }
            else
            {
                continueButton++;
                RegisterButton++;

                if (continueButton == 1)
                {
                    SmoothProgress(kryptonProgressBar1.Maximum / 2);
                }
                else if (RegisterButton == 2)
                {
                    SmoothProgress(kryptonProgressBar1.Maximum);

                }
                MessageBox.Show($"Username: {usernameTxtBox.Text}" +
                    $"\nConfirm Password: {confirmPassword.Text}" +
                    $"\nEmail: {emailTextBox.Text}" +
                    $"\nRole: {RoleTextBox.Text}" +
                    $"\nFirst Name: {firstNameTextBox.Text}" +
                    $"\nMiddle Name: {middleNameTextBox.Text}" +
                    $"\nLast Name: {lastNameTextBox.Text}" +
                    $"\nContact Number: {contactNumTextBox.Text}" +
                    $"\nSex: {sexTextBox.Text}" +
                    $"\nBirth Date: {birthdayTextBox.Text}" +
                    $"\nSpecialization: {specializationTextBox.Text}" +
                    $"\nLicense No. : {licenseTextBox.Text}");
            }
        }

        private void signUpPart2_Paint(object sender, PaintEventArgs e)
        {
            this.Hide();
        }
        //value for gender
        private void contextGender_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            sexTextBox.Text = e.ClickedItem.Text;
        }
        //value for specialization
        private void contextSpecialization_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            specializationTextBox.Text = e.ClickedItem.Text;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            signUpPart2.Hide();
            signUpPart1.Show();

            if (continueButton > 0)
                continueButton--;

            if (RegisterButton > 0)
                RegisterButton--;

            if (continueButton == 0)
            {
                SmoothProgress(0); 
            }
            else if (continueButton == 1)
            {
                SmoothProgress(1); 
            }
        }
    }

}
