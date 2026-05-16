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

namespace hrms_client.Testing
{
    public partial class CustomList : UserControl
    {
        // Define controls
        private KryptonLabel lblTitle;
        private KryptonLabel lblDescription;
        private KryptonPictureBox picIcon;
        private KryptonButton btnAction;

        // Event to notify when the button is clicked
        public event EventHandler<CustomListItemEventArgs> ButtonClick;

        public CustomList()
        {
            InitializeComponent();

            // Initialize controls
            lblTitle = new KryptonLabel
            {
                Text = "Title",
                Dock = DockStyle.Top
            };

            lblDescription = new KryptonLabel
            {
                Text = "Description",
                Dock = DockStyle.Top
            };

            picIcon = new KryptonPictureBox
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Left,
                Width = 50
            };

            btnAction = new KryptonButton
            {
                Text = "Action",
                Dock = DockStyle.Bottom
            };

            // Add controls to the user control
            this.Controls.Add(lblTitle);
            this.Controls.Add(lblDescription);
            this.Controls.Add(picIcon);
            this.Controls.Add(btnAction);

            // Handle button click
            btnAction.Click += BtnAction_Click;
        }

        // Properties to set the data
        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public string Description
        {
            get { return lblDescription.Text; }
            set { lblDescription.Text = value; }
        }

        public Image Icon
        {
            get { return picIcon.Image; }
            set { picIcon.Image = value; }
        }

        // Handle button click
        private void BtnAction_Click(object sender, EventArgs e)
        {
            // Raise the ButtonClick event and pass the data
            ButtonClick?.Invoke(this, new CustomListItemEventArgs
            {
                Title = this.Title,
                Description = this.Description,
                Icon = this.Icon
            });
        }
    }

    // Custom event arguments to pass data
    public class CustomListItemEventArgs : EventArgs
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Image Icon { get; set; }
    }
}
