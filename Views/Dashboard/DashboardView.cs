using hrms_client.Presenters.Interface;
using hrms_client.Views.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace hrms_client.Views.Dashboard
{
    public partial class DashboardView : KryptonForm, IDashboardView
    {
        private bool isSuccessful;
        private string message;

        private Dictionary<KryptonButton, Panel> ButtonControlsMap;
        //private KryptonButton CurrentSelectedButton;

        private static readonly Color SelectedBackgroundColor1 = Color.FromArgb(4, 70, 87);
        private static readonly Color SelectedBackgroundColor2 = Color.FromArgb(58, 94, 116);
        private static readonly Color SelectedTextColor = Color.FromArgb(251, 252, 252);
        private static readonly Color DefaultTextColor = Color.FromArgb(251, 252, 252);
        private static readonly Font SelectedFont = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);

        public event EventHandler ShowRecords;
        public event EventHandler ShowConsults;
        public event EventHandler ShowScanQR;
        public event EventHandler ShowBillings;
        public event EventHandler LogoutEvent;
        public event EventHandler FormCloseEvent;
        public event EventHandler FormLoadEvent;

        public DashboardView()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
            //InitializeSelectedButtonAndPanel();
        }

        private void AssociateAndRaiseEvents()
        {
            recordsBtn.Click += (s, e) => { ShowRecords?.Invoke(this, EventArgs.Empty); };
            consultBtn.Click += (s, e) => { ShowConsults?.Invoke(this, EventArgs.Empty); };
            qrScanBtn.Click += (s, e) => { ShowScanQR?.Invoke(this, EventArgs.Empty); };
            billingsBtn.Click += (s, e) => { ShowBillings?.Invoke(this, EventArgs.Empty); };
            logoutBtn.Click += (s, e) => { LogoutEvent?.Invoke(this, EventArgs.Empty); };
            this.FormClosed += (s, e) => { FormCloseEvent?.Invoke(this, EventArgs.Empty); };
            this.Load += (s, e) => { FormLoadEvent?.Invoke(this, EventArgs.Empty); };
        }

        public void SetSelectedDefaultButton(KryptonButton DefaultButton)
        {
            //if (DefaultButton == null) return;

            //// Ensure all panels are hidden before selecting the default one
            //HideAllPanels();


            //// Apply selected appearance
            //SetButtonSelectedAppearance(DefaultButton);

            //// Update the currently selected button
            //CurrentSelectedButton = defaultButton;
            MessageBox.Show("Default Button");
        }

        public void SetButtonSelectedAppearance(KryptonButton button)
        {
            button.OverrideDefault.Back.Color1 = SelectedBackgroundColor1;
            button.OverrideDefault.Back.Color2 = SelectedBackgroundColor2;
            button.OverrideDefault.Back.ColorAngle = -55F;
            button.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Linear33;
            button.OverrideDefault.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            button.OverrideDefault.Border.Color1 = Color.Transparent;
            button.OverrideDefault.Border.Color2 = Color.Transparent;
            button.OverrideDefault.Content.AdjacentGap = 10;
            button.OverrideDefault.Content.ShortText.Color1 = SelectedTextColor;
            button.OverrideDefault.Content.ShortText.Color2 = SelectedTextColor;
            button.OverrideDefault.Content.ShortText.Font = SelectedFont;

            button.Invalidate();
        }

        public void ResetButtonAppearance(KryptonButton button)
        {
            button.StateCommon.Back.Color1 = Color.Transparent;
            button.StateCommon.Back.Color2 = Color.Transparent;
            button.StateCommon.Content.ShortText.Color1 = DefaultTextColor;
            button.StateCommon.Content.ShortText.Color2 = DefaultTextColor;
            button.StateCommon.Border.Color1 = Color.Transparent;
            button.StateCommon.Border.Color2 = Color.Transparent;
        }

        public IDashboardPresenter Presenter { get; set; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }
        public KryptonPanel panelContainer { get => mainPanelLoader; set => mainPanelLoader = value; }
        public string UsernameLabel 
        { 
            get => usernameLabel.Text;
            set => usernameLabel.Text = value; 
        }
        public string UserRoleLabel 
        { 
            get => userRoleLabel.Text; 
            set => userRoleLabel.Text = value; 
        }
        
        public KryptonPanel RecordsSelectedPanel { get => recordsSelectedPanel;  }
        public KryptonPanel ConsultSelectedPanel { get => consultsSelectedPanel; }
        public KryptonPanel QrScanSelectedPanel { get => qrScanSelectedPanel; }
        public KryptonPanel BillingsSelectedPanel { get => billingsSelectedPanel; }
        public KryptonButton CurrentSelectedButton { get; set; }

        public KryptonButton RecordsButton => recordsBtn;

        public KryptonButton ConsultsButton => consultBtn;

        public KryptonButton QrScanButton => qrScanBtn;

        public KryptonButton BillingsButton => billingsBtn;


        //private void Button_Click(object sender, EventArgs e)
        //{
        //    // Get the clicked button
        //    var clickedButton = sender as KryptonButton;

        //    // If the clicked button is already selected, do nothing
        //    if (clickedButton == CurrentSelectedButton)
        //        return;

        //    // Hide all panels
        //    HideAllPanels();

        //    // Show the corresponding panel
        //    if (ButtonControlsMap.ContainsKey(clickedButton))
        //    {
        //        ButtonControlsMap[clickedButton].Visible = true;
        //    }

        //    // Reset the appearance of the previously selected button
        //    if (CurrentSelectedButton != null)
        //    {
        //        ResetButtonAppearance(CurrentSelectedButton);
        //    }

        //    // Update the appearance of the newly selected button
        //    SetButtonSelectedAppearance(clickedButton);

        //    // Update the currently selected button
        //    CurrentSelectedButton = clickedButton;
        //}

        private void HideAllPanels()
        {
            foreach (var panel in ButtonControlsMap.Values)
            {
                panel.Visible = false;
            }
        }

        //private void SetDefaultButton(KryptonButton defaultButton)
        //{
        //    if (defaultButton == null) return;

        //    // Ensure all panels are hidden before selecting the default one
        //    HideAllPanels();

        //    // Show the corresponding panel
        //    if (ButtonControlsMap.ContainsKey(defaultButton))
        //    {
        //        ButtonControlsMap[defaultButton].Visible = true;
        //    }

        //    // Apply selected appearance
        //    SetButtonSelectedAppearance(defaultButton);

        //    // Update the currently selected button
        //    CurrentSelectedButton = defaultButton;
        //}

        //private void ResetButtonAppearance(KryptonButton button)
        //{
        //    // Reset the button's appearance to its default state
        //    button.StateCommon.Back.Color1 = Color.Transparent;
        //    button.StateCommon.Back.Color2 = Color.Transparent;
        //    button.StateCommon.Content.ShortText.Color1 = DefaultTextColor;
        //    button.StateCommon.Content.ShortText.Color2 = DefaultTextColor;
        //    button.StateCommon.Border.Color1 = Color.Transparent;
        //    button.StateCommon.Border.Color2 = Color.Transparent;

        //    button.Invalidate();
        //}

        //private void SetButtonSelectedAppearance(KryptonButton button)
        //{
        //    // Update the button's appearance to indicate it is selected
        //    button.OverrideDefault.Back.Color1 = SelectedBackgroundColor1;
        //    button.OverrideDefault.Back.Color2 = SelectedBackgroundColor2;
        //    button.OverrideDefault.Back.ColorAngle = -55F;
        //    button.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Linear33;
        //    button.OverrideDefault.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
        //    button.OverrideDefault.Border.Color1 = Color.Transparent;
        //    button.OverrideDefault.Border.Color2 = Color.Transparent;
        //    button.OverrideDefault.Content.AdjacentGap = 10;
        //    button.OverrideDefault.Content.ShortText.Color1 = SelectedTextColor;
        //    button.OverrideDefault.Content.ShortText.Color2 = SelectedTextColor;
        //    button.OverrideDefault.Content.ShortText.Font = SelectedFont;

        //    button.Invalidate();
        //}
    }
}