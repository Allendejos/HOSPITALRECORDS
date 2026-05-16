//using Krypton.Toolkit;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Drawing.Text;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace hrms_client

//{
//    public partial class hpvCopy : Form
//    {

//        private bool dragging = false;
//        private Point dragCursorPoint;
//        private Point dragFormPoint;
//        private bool allFilled;
//        string PatientNo, PFirstName, PMiddleName, PLastName;
//        private List<hrms_client.Views.Patient> patientList = new List<hrms_client.Views.Patient>();
//        private Dictionary<string, (Label firstName, Label middleName, Label lastName)> labelDictionary = new Dictionary<string, (Label, Label, Label)>();
//        private Random random = new Random();
//        Label LFirstName;
//        Label LMiddleName;
//        Label LLastName;
//        Panel panel;

//        public hpvCopy()
//        {
//            InitializeComponent();

//            panel2.MouseDown += Panel_MouseDown;
//            panel2.MouseMove += Panel_MouseMove;
//            panel2.MouseUp += Panel_MouseUp;

//        }

//        private void TextBoxClear(params Krypton.Toolkit.KryptonTextBox[] textBox)
//        {
//            foreach (var btn in textBox)
//            {

//            }
//        }

//        private void SetPlaceholders(params (KryptonTextBox textBox, string placeholder)[] textBoxes)
//        {
//            foreach (var (textBox, placeholder) in textBoxes)
//            {
//                textBox.Text = placeholder;
//                textBox.StateCommon.Content.Color1 = Color.Gray; // Placeholder color

//                textBox.Enter += (s, e) =>
//                {
//                    if (textBox.Text == placeholder)
//                    {
//                        textBox.Text = "";
//                        textBox.StateCommon.Content.Color1 = Color.Black; // Normal text color
//                    }
//                };

//                textBox.Leave += (s, e) =>
//                {
//                    if (string.IsNullOrWhiteSpace(textBox.Text))
//                    {
//                        textBox.Text = placeholder;
//                        textBox.StateCommon.Content.Color1 = Color.Gray;
//                    }
//                };
//            }
//        }

//        private bool TextBoxInputChecker(params (KryptonTextBox textBox, string placeholder)[] textBoxes)
//        {
//            foreach (var (textBox, placeholder) in textBoxes)
//            {
//                if (string.IsNullOrWhiteSpace(textBox.Text) || textBox.Text == placeholder)
//                {
//                    return false; // If any textbox is empty or still has placeholder, return false
//                }
//            }
//            return true; // All inputs are valid
//        }

//        private void EnabledButtons(bool isDetailsOpen, bool isViewDetailsPatient)
//        {
//            if (isViewDetailsPatient)
//            {
//                if (isDetailsOpen)
//                {
//                    FlowPanel.Visible = false;
//                    Header.Visible = false;
//                    KTBSearch.Enabled = false;
//                    KBAddPatient.Enabled = false;


//                }
//                else
//                {
//                    FlowPanel.Visible = true;
//                    Header.Visible = true;
//                    KTBSearch.Enabled = true;
//                    KBAddPatient.Enabled = true;

//                }
//            }
//            else
//            {
//                if (isDetailsOpen)
//                {
//                    KPDetailsPatient.Visible = false;
//                    FlowPanel.Visible = true;
//                    Header.Visible = true;
//                    KTBSearch.Enabled = true;
//                    KBAddPatient.Enabled = true;
//                    KBAddPatient.Enabled = true;
//                }
//                else
//                {
//                    FlowPanel.Visible = false;
//                    Header.Visible = false;
//                    KTBSearch.Enabled = false;
//                    KBAddPatient.Enabled = false;
//                    KPDetailsPatient.Visible = true;
//                }
//            }
//        }

//        private void PanelViewDetails(Patient patient)
//        {
//            KDFn.Text = patient.FirstName;
//            KDLn.Text = patient.LastName;
//            KDMn.Text = patient.MiddleName;
//            KDPiD.Text = patient.PatientNo;
//            KDEmail.Text = patient.Email;
//            KDOcc.Text = patient.Occupation;
//            KDContNo.Text = patient.ContactNo;
//            KDAddress.Text = patient.Address;
//            KDGFn.Text = patient.GFirstname;
//            KDGLn.Text = patient.GLastname;
//            KDGCn.Text = patient.GContactNo;
//            KDGRelation.Text = patient.GRelationship;
//            DDateOfBirth.Text = patient.DateOfBirth;

//            EnabledButtons(true, true);
//            KPViewDetails.Visible = true;

//        }

//        private void PanelUpdateDetails(Patient patient)
//        {
//            KUFn.Text = patient.FirstName;
//            KULn.Text = patient.LastName;
//            KUMn.Text = patient.MiddleName;
//            KUPiD.Text = patient.PatientNo;
//            KUEmail.Text = patient.Email;
//            KUOcc.Text = patient.Occupation;
//            KUCNo.Text = patient.ContactNo;
//            KUAddress.Text = patient.Address;
//            KUGFn.Text = patient.GFirstname;
//            KUGLn.Text = patient.GLastname;
//            KUGCno.Text = patient.GContactNo;
//            KUGRelation.Text = patient.GRelationship;
//            UDateOfBirth.Text = patient.DateOfBirth;

//            EnabledButtons(true, true);
//            KUpdateDetails.Visible = true;

//        }

//        private void Panel_MouseDown(object sender, MouseEventArgs e)
//        {
//            dragging = true;
//            dragCursorPoint = Cursor.Position;
//            dragFormPoint = this.Location;
//        }

//        private void Panel_MouseMove(object sender, MouseEventArgs e)
//        {
//            if (dragging)
//            {
//                Point newPosition = new Point(
//                    dragFormPoint.X + (Cursor.Position.X - dragCursorPoint.X),
//                    dragFormPoint.Y + (Cursor.Position.Y - dragCursorPoint.Y)
//                );
//                this.Location = newPosition;
//            }
//        }

//        private void Panel_MouseUp(object sender, MouseEventArgs e)
//        {
//            dragging = false;
//        }


//        private void SetButtonStyles(Krypton.Toolkit.KryptonButton activeButton, params Krypton.Toolkit.KryptonButton[] otherButtons)
//        {
//            activeButton.OverrideDefault.Back.Color1 = Color.White;
//            activeButton.OverrideDefault.Back.Color2 = Color.White;
//            activeButton.StateCommon.Content.ShortText.Font = new Font("Poppins", 10F);
//            activeButton.Size = new Size(170, 45);

//            // Reset styles for other buttons
//            foreach (var btn in otherButtons)
//            {
//                KBPatientRecord.StateCommon.Back.Color1 = Color.FromArgb(128, 255, 255, 255);
//                KBPatientRecord.StateCommon.Back.Color2 = Color.FromArgb(128, 255, 255, 255);
//                btn.Font = new Font(activeButton.Font, FontStyle.Regular);
//                btn.Size = new Size(156, 39);
//                btn.Values.DropDownArrowColor = Color.Empty;
//            }
//        }



//        //==========================================================================================================
//        private void Form1_Load(object sender, EventArgs e)
//        {

//        }

//        private void button6_Click(object sender, EventArgs e)
//        {
//            Application.Exit();

//        }

//        private void BLogout_MouseClick(object sender, MouseEventArgs e)
//        {
//            //WAla pani
//        }


//        private void BViewMedical_MouseClick_1(object sender, MouseEventArgs e)
//        {
//            EnabledButtons(false, true);
//            KPViewDetails.Visible = false;
//        }



//        private void TBDateOfBirth_DropDown(object sender, EventArgs e)
//        {
//            TBDateOfBirth.CustomFormat = "d MMMM yyyy";
//            TBDateOfBirth.Value = DateTime.Today;
//        }


//        private void KBPatientRecord_MouseClick(object sender, MouseEventArgs e)
//        {

//            MainPatientRecordPanel.Visible = true;
//            SetButtonStyles(KBPatientRecord, KBConsultation, KBScanQr, KBBillings);


//        }

//        private void KBConsultation_MouseClick(object sender, MouseEventArgs e)
//        {
//            MainPatientRecordPanel.Visible = false;
//            SetButtonStyles(KBConsultation, KBPatientRecord, KBScanQr, KBBillings);
//        }

//        private void KBScanQr_MouseClick(object sender, MouseEventArgs e)
//        {
//            MainPatientRecordPanel.Visible = false;
//            SetButtonStyles(KBScanQr, KBPatientRecord, KBConsultation, KBBillings);
//        }

//        private void KBBillings_MouseClick(object sender, MouseEventArgs e)
//        {
//            MainPatientRecordPanel.Visible = false;
//            SetButtonStyles(KBBillings, KBPatientRecord, KBConsultation, KBScanQr);

//        }

//        private void KBAddPatient_MouseClick(object sender, MouseEventArgs e)
//        {
//            EnabledButtons(false, false);

//            TextBoxClear(KTBiFirstname, KTBiMiddlename, KTBiLastname, KTBiEmail, KTBiOccupation, KTBiContactNo, KTBiAddress, KTBGifn, KTBGiLn, KTBGiCn, KTBGiR);
//            SetPlaceholders((KTBiFirstname, "Enter first name"), (KTBiMiddlename, "Enter middle name"), (KTBiLastname, "Enter last name"),
//                            (KTBiEmail, "Enter email"), (KTBiOccupation, "Enter occupation"), (KTBiContactNo, "Enter contact no."),
//                            (KTBiAddress, "Enter address"), (KTBGifn, "Enter first name"), (KTBGiLn, "Enter last name"), (KTBGiCn, "Enter contact no"), (KTBGiR, "Enter relationshuip"));
//            TBDateOfBirth.CustomFormat = " ";
//        }

//        private void usernameTxtBox_Enter(object sender, EventArgs e)
//        {
//            if (KTBSearch.Text == " Search Patient")
//            {
//                KTBSearch.Text = "";
//                KTBSearch.StateCommon.Content.Color1 = Color.Black;
//            }
//        }

//        private void KBSaveDetails_MouseClick(object sender, MouseEventArgs e)
//        {

//        }

//        private void KBCancel_MouseClick(object sender, MouseEventArgs e)
//        {
//            EnabledButtons(true, false);
//        }

//        private void KBSaveDetails_MouseClick_1(object sender, MouseEventArgs e)
//        {
//            PatientNo = "23-" + random.Next(50000, 100000).ToString();

//            allFilled = true;
//            allFilled = TextBoxInputChecker((KTBiFirstname, "Enter first name"), (KTBiMiddlename, "Enter middle name"), (KTBiLastname, "Enter last name"),
//                            (KTBiEmail, "Enter email"), (KTBiOccupation, "Enter occupation"), (KTBiContactNo, "Enter contact no."),
//                            (KTBiAddress, "Enter address"), (KTBGifn, "Enter first name"), (KTBGiLn, "Enter last name"), (KTBGiCn, "Enter contact no"), (KTBGiR, "Enter relationshuip"));


//            if (allFilled)
//            {
//                string newPatientId = KTBiPatientId.Text;
//                bool idExists = patientList.Any(p => p.PatientNo == newPatientId);

//                if (idExists)
//                {
//                    MessageBox.Show("This Patient ID already exists. Please use a different ID.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                }
//                else
//                {
//                    int panelWidth = FlowPanel.Width - FlowPanel.Padding.Left - FlowPanel.Padding.Right;

//                    Patient newPatient = new Patient
//                    {
//                        FirstName = KTBiFirstname.Text,
//                        LastName = KTBiLastname.Text,
//                        MiddleName = KTBiMiddlename.Text,
//                        PatientNo = PatientNo,
//                        Email = KTBiEmail.Text,
//                        Occupation = KTBiOccupation.Text,
//                        ContactNo = KTBiContactNo.Text,
//                        Address = KTBiAddress.Text,
//                        GFirstname = KTBGifn.Text,
//                        GLastname = KTBGiLn.Text,
//                        GContactNo = KTBGiCn.Text,
//                        GRelationship = KTBGiR.Text,
//                        DateOfBirth = TBDateOfBirth.Value.ToString("d MMMM yyyy")
//                    };

//                    patientList.Add(newPatient);
//                    //DateOfBirth = TBDateOfBirth.Text;
//                    PFirstName = newPatient.FirstName;
//                    PLastName = newPatient.LastName;
//                    PMiddleName = newPatient.MiddleName;


//                    panel = new Panel()
//                    {
//                        Size = new Size(panelWidth - 30, 90),
//                        Location = new Point(10, 30),
//                        BackColor = Color.FromArgb(210, 225, 237),
//                        BorderStyle = BorderStyle.None,
//                        Margin = new Padding(10, 8, 1, 4),

//                    };

//                    Label Idno = new Label
//                    {

//                        Text = $"{PatientNo}",
//                        Font = new Font("Poppins", 12F, FontStyle.Bold),
//                        ForeColor = Color.Black,
//                        AutoSize = true,
//                        Location = new Point(5, 31)
//                    };

//                    LFirstName = new Label
//                    {

//                        Text = $"{PFirstName}",
//                        Font = new Font("Poppins", 11F),
//                        ForeColor = Color.Black,
//                        AutoSize = true,
//                        Location = new Point(241, 31)


//                    };

//                    LLastName = new Label
//                    {

//                        Text = $"{PLastName.ToUpper()}",
//                        Font = new Font("Poppins", 11F),
//                        ForeColor = Color.Black,
//                        AutoSize = true,
//                        Location = new Point(108, 31)


//                    };

//                    LMiddleName = new Label
//                    {

//                        Text = $"{PMiddleName}",
//                        Font = new Font("Poppins", 11F),
//                        ForeColor = Color.Black,
//                        AutoSize = true,
//                        Location = new Point(395, 31)


//                    };


//                    Button UpdateButton = new Button
//                    {
//                        BackColor = Color.FromArgb(9, 195, 51),
//                        Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Bold),
//                        ForeColor = Color.White,
//                        Location = new Point(675, 28),
//                        Name = "update",
//                        Size = new Size(73, 33),
//                        TabIndex = 7,
//                        Text = "Update",
//                        UseVisualStyleBackColor = false

//                    };

//                    Button viewButton = new Button
//                    {
//                        BackColor = Color.FromArgb(58, 94, 116),
//                        Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Bold),
//                        ForeColor = Color.White,
//                        Location = new Point(600, 28),
//                        Name = "View",
//                        Size = new Size(73, 33),
//                        TabIndex = 7,
//                        Text = "View",
//                        UseVisualStyleBackColor = false

//                    };

//                    viewButton.Click += (s, args) => PanelViewDetails(newPatient);
//                    UpdateButton.Click += (s, args) => PanelUpdateDetails(newPatient);

//                    panel.Controls.Add(LMiddleName);
//                    panel.Controls.Add(LLastName);
//                    panel.Controls.Add(LFirstName);
//                    panel.Controls.Add(Idno);
//                    panel.Controls.Add(viewButton);
//                    panel.Controls.Add(UpdateButton);
//                    labelDictionary[PatientNo] = (LFirstName, LMiddleName, LLastName);
//                    panelList.Add(panel);
//                    FlowPanel.Controls.Add(panel);
//                    EnabledButtons(true, false);
//                }

//            }
//            else
//            {
//                MessageBox.Show("Please fill in all fields before proceeding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//            }
//        }

//        private void KBViewMedicR_MouseClick(object sender, MouseEventArgs e)
//        {
//            EnabledButtons(false, true);
//            KPViewDetails.Visible = false;
//        }

//        private void KBUpdate_MouseClick(object sender, MouseEventArgs e)
//        {
//            Patient selectedPatient = patientList.FirstOrDefault(p => p.PatientNo == KUPiD.Text);

//            if (selectedPatient != null)
//            {
//                selectedPatient.FirstName = KUFn.Text;
//                selectedPatient.LastName = KULn.Text;
//                selectedPatient.MiddleName = KUMn.Text;
//                selectedPatient.PatientNo = KUPiD.Text;
//                selectedPatient.Email = KUEmail.Text;
//                selectedPatient.Occupation = KUOcc.Text;
//                selectedPatient.ContactNo = KUCNo.Text;
//                selectedPatient.Address = KUAddress.Text;
//                selectedPatient.GFirstname = KUGFn.Text;
//                selectedPatient.GLastname = KUGLn.Text;
//                selectedPatient.GContactNo = KUGCno.Text;
//                selectedPatient.GRelationship = KUGRelation.Text;
//                selectedPatient.DateOfBirth = UDateOfBirth.Value.ToString("d MMMM yyyy");

//                if (labelDictionary.ContainsKey(selectedPatient.PatientNo))
//                {
//                    var (firstNameLabel, middleNameLabel, lastNameLabel) = labelDictionary[selectedPatient.PatientNo];

//                    firstNameLabel.Text = selectedPatient.FirstName;
//                    middleNameLabel.Text = selectedPatient.MiddleName;
//                    lastNameLabel.Text = selectedPatient.LastName.ToUpper();
//                }
//            }

//            EnabledButtons(false, true);
//            KUpdateDetails.Visible = false;
//        }

//        private void KUBcancel_MouseClick(object sender, MouseEventArgs e)
//        {

//            EnabledButtons(false, true);
//            KUpdateDetails.Visible = false;
//        }

//        private void ExitButton_MouseClick(object sender, MouseEventArgs e)
//        {
//            Application.Exit();
//        }

//        private void KTBSearch_TextChanged(object sender, EventArgs e)
//        {
//            string searchText = KTBSearch.Text.Trim().ToLower();

//            foreach (var panel in panelList)
//            {
//                panel.Visible = false;
//            }

//            foreach (var patient in patientList)
//            {
//                if (patient.FirstName.ToLower().Contains(searchText) ||
//                    patient.MiddleName.ToLower().Contains(searchText) ||
//                    patient.LastName.ToLower().Contains(searchText))
//                {
//                    if (labelDictionary.ContainsKey(patient.PatientNo))
//                    {
//                        var (firstNameLabel, middleNameLabel, lastNameLabel) = labelDictionary[patient.PatientNo];

//                        foreach (var panel in panelList)
//                        {
//                            if (panel.Controls.Contains(firstNameLabel) && panel.Controls.Contains(middleNameLabel) && panel.Controls.Contains(lastNameLabel))
//                            {
//                                panel.Visible = true;
//                                break;
//                            }
//                        }
//                    }
//                }
//            }
//        }

//        //private void TBFn_TextChanged(object sender, EventArgs e)
//        //{
//        //    CheckTextBoxes();
//        //}

//        //private void CheckTextBoxes()
//        //{

//        //}

//    }
//}