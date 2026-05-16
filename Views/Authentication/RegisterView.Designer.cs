using hrms_query.Models.Enums;

namespace hrms_client.Views
{
    partial class RegisterView
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
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            cancelBtn = new Button();
            panelReg = new Panel();
            emailText = new TextBox();
            label14 = new Label();
            medLicenseText = new TextBox();
            specializationOptions = new ComboBox();
            label13 = new Label();
            label11 = new Label();
            contactNumText = new TextBox();
            label10 = new Label();
            genderOptions = new ComboBox();
            label9 = new Label();
            label5 = new Label();
            firstNameText = new TextBox();
            label6 = new Label();
            middleNameText = new TextBox();
            label7 = new Label();
            lastNameText = new TextBox();
            label4 = new Label();
            userNameText = new TextBox();
            positionOptions = new ComboBox();
            label3 = new Label();
            roleLabel = new Label();
            confirmPassText = new TextBox();
            label2 = new Label();
            confirmPassLabel = new Label();
            passwordText = new TextBox();
            registerBtn = new Button();
            textBox1 = new TextBox();
            passwordLabel = new Label();
            label1 = new Label();
            usernameLabel = new Label();
            panel2 = new Panel();
            registerLabel = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panelReg.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(622, 429);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(passwordLabel);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(usernameLabel);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 55);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(622, 374);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(cancelBtn);
            panel4.Controls.Add(panelReg);
            panel4.Controls.Add(registerBtn);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(622, 374);
            panel4.TabIndex = 6;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(315, 324);
            cancelBtn.Margin = new Padding(3, 2, 3, 2);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(165, 41);
            cancelBtn.TabIndex = 12;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // panelReg
            // 
            panelReg.Controls.Add(emailText);
            panelReg.Controls.Add(label14);
            panelReg.Controls.Add(medLicenseText);
            panelReg.Controls.Add(specializationOptions);
            panelReg.Controls.Add(label13);
            panelReg.Controls.Add(label11);
            panelReg.Controls.Add(contactNumText);
            panelReg.Controls.Add(label10);
            panelReg.Controls.Add(genderOptions);
            panelReg.Controls.Add(label9);
            panelReg.Controls.Add(label5);
            panelReg.Controls.Add(firstNameText);
            panelReg.Controls.Add(label6);
            panelReg.Controls.Add(middleNameText);
            panelReg.Controls.Add(label7);
            panelReg.Controls.Add(lastNameText);
            panelReg.Controls.Add(label4);
            panelReg.Controls.Add(userNameText);
            panelReg.Controls.Add(positionOptions);
            panelReg.Controls.Add(label3);
            panelReg.Controls.Add(roleLabel);
            panelReg.Controls.Add(confirmPassText);
            panelReg.Controls.Add(label2);
            panelReg.Controls.Add(confirmPassLabel);
            panelReg.Controls.Add(passwordText);
            panelReg.Location = new Point(10, 4);
            panelReg.Margin = new Padding(3, 2, 3, 2);
            panelReg.Name = "panelReg";
            panelReg.Size = new Size(601, 305);
            panelReg.TabIndex = 11;
            // 
            // emailText
            // 
            emailText.Location = new Point(195, 220);
            emailText.Margin = new Padding(3, 2, 3, 2);
            emailText.Name = "emailText";
            emailText.Size = new Size(115, 23);
            emailText.TabIndex = 29;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            label14.Location = new Point(350, 187);
            label14.Name = "label14";
            label14.Size = new Size(136, 15);
            label14.TabIndex = 27;
            label14.Text = "Medical License No:";
            // 
            // medLicenseText
            // 
            medLicenseText.Location = new Point(350, 212);
            medLicenseText.Margin = new Padding(3, 2, 3, 2);
            medLicenseText.Name = "medLicenseText";
            medLicenseText.Size = new Size(210, 23);
            medLicenseText.TabIndex = 28;
            // 
            // specializationOptions
            // 
            specializationOptions.FormattingEnabled = true;
            specializationOptions.Location = new Point(350, 148);
            specializationOptions.Margin = new Padding(3, 2, 3, 2);
            specializationOptions.Name = "specializationOptions";
            specializationOptions.Size = new Size(210, 23);
            specializationOptions.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            label13.Location = new Point(347, 129);
            label13.Name = "label13";
            label13.Size = new Size(156, 15);
            label13.TabIndex = 25;
            label13.Text = "Specialization (Doctor)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            label11.Location = new Point(33, 228);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 22;
            // 
            // contactNumText
            // 
            contactNumText.Location = new Point(195, 245);
            contactNumText.Margin = new Padding(3, 2, 3, 2);
            contactNumText.Name = "contactNumText";
            contactNumText.Size = new Size(115, 23);
            contactNumText.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            label10.Location = new Point(33, 253);
            label10.Name = "label10";
            label10.Size = new Size(114, 15);
            label10.TabIndex = 20;
            label10.Text = "Contact Number";
            // 
            // genderOptions
            // 
            genderOptions.FormattingEnabled = true;
            genderOptions.Location = new Point(195, 195);
            genderOptions.Margin = new Padding(3, 2, 3, 2);
            genderOptions.Name = "genderOptions";
            genderOptions.Size = new Size(115, 23);
            genderOptions.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            label9.Location = new Point(33, 199);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 18;
            label9.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            label5.Location = new Point(33, 124);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 10;
            label5.Text = "First Name";
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(195, 121);
            firstNameText.Margin = new Padding(3, 2, 3, 2);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(115, 23);
            firstNameText.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            label6.Location = new Point(33, 153);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 12;
            label6.Text = "Middle Name";
            // 
            // middleNameText
            // 
            middleNameText.Location = new Point(195, 146);
            middleNameText.Margin = new Padding(3, 2, 3, 2);
            middleNameText.Name = "middleNameText";
            middleNameText.Size = new Size(115, 23);
            middleNameText.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            label7.Location = new Point(33, 178);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 14;
            label7.Text = "Last Name";
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(195, 170);
            lastNameText.Margin = new Padding(3, 2, 3, 2);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(115, 23);
            lastNameText.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            label4.Location = new Point(33, 29);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 0;
            label4.Text = "Username";
            // 
            // userNameText
            // 
            userNameText.Location = new Point(195, 26);
            userNameText.Margin = new Padding(3, 2, 3, 2);
            userNameText.Name = "userNameText";
            userNameText.Size = new Size(115, 23);
            userNameText.TabIndex = 1;
            userNameText.TextChanged += userNameText_TextChanged;
            // 
            // positionOptions
            // 
            positionOptions.FormattingEnabled = true;
            positionOptions.Location = new Point(347, 85);
            positionOptions.Margin = new Padding(3, 2, 3, 2);
            positionOptions.Name = "positionOptions";
            positionOptions.Size = new Size(212, 23);
            positionOptions.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            label3.Location = new Point(33, 224);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            roleLabel.Location = new Point(347, 60);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(104, 15);
            roleLabel.TabIndex = 8;
            roleLabel.Text = "Position / Role";
            // 
            // confirmPassText
            // 
            confirmPassText.Location = new Point(195, 78);
            confirmPassText.Margin = new Padding(3, 2, 3, 2);
            confirmPassText.Name = "confirmPassText";
            confirmPassText.Size = new Size(115, 23);
            confirmPassText.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            label2.Location = new Point(33, 58);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // confirmPassLabel
            // 
            confirmPassLabel.AutoSize = true;
            confirmPassLabel.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            confirmPassLabel.Location = new Point(33, 85);
            confirmPassLabel.Name = "confirmPassLabel";
            confirmPassLabel.Size = new Size(126, 15);
            confirmPassLabel.TabIndex = 6;
            confirmPassLabel.Text = "Confirm Password";
            // 
            // passwordText
            // 
            passwordText.Location = new Point(195, 50);
            passwordText.Margin = new Padding(3, 2, 3, 2);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(115, 23);
            passwordText.TabIndex = 5;
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(125, 324);
            registerBtn.Margin = new Padding(3, 2, 3, 2);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(154, 41);
            registerBtn.TabIndex = 10;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 176);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 23);
            textBox1.TabIndex = 5;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(38, 178);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(83, 17);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 118);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(38, 57);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(88, 18);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username";
            // 
            // panel2
            // 
            panel2.Controls.Add(registerLabel);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(622, 55);
            panel2.TabIndex = 0;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerLabel.Location = new Point(27, 14);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(101, 20);
            registerLabel.TabIndex = 0;
            registerLabel.Text = "REGISTER";
            // 
            // RegisterView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 429);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegisterView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterFormView";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panelReg.ResumeLayout(false);
            panelReg.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label usernameLabel;
        private Panel panel2;
        private Label registerLabel;
        private TextBox textBox1;
        private Label passwordLabel;
        private Label label1;
        private Panel panel4;
        private Label roleLabel;
        private TextBox confirmPassText;
        private Label confirmPassLabel;
        private TextBox passwordText;
        private Label label2;
        private Label label3;
        private TextBox userNameText;
        private Label label4;
        private ComboBox positionOptions;
        private Button registerBtn;
        private Panel panelReg;
        private Label label5;
        private TextBox firstNameText;
        private Label label6;
        private TextBox middleNameText;
        private Label label7;
        private TextBox lastNameText;
        private Label label11;
        private TextBox contactNumText;
        private Label label10;
        private ComboBox genderOptions;
        private Label label9;
        private Label label14;
        private TextBox medLicenseText;
        private ComboBox specializationOptions;
        private Label label13;
        private TextBox emailText;
        private Button cancelBtn;
    }
}