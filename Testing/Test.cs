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
    public partial class Test : KryptonForm
    {
        private KryptonPanel parentPanel;

        public Test()
        {
            InitializeComponent();

            // Initialize parentPanel
            parentPanel = new KryptonPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };
            this.Controls.Add(parentPanel); // Add to the form

            // Populate the list with sample data
            PopulateList();
        }

        private void PopulateList()
        {
            // Clear existing items
            parentPanel.Controls.Clear();

            // Add sample data
            AddPanelToList("Item 1", "This is the first item.", null);
            AddPanelToList("Item 2", "This is the second item.", null);
            AddPanelToList("Item 3", "This is the third item.", null);
        }

        private void AddPanelToList(string title, string description, Image icon)
        {
            // Create a new instance of the custom panel
            CustomList item = new CustomList
            {
                Title = title,
                Description = description,
                Icon = icon,
                Dock = DockStyle.Top,
                Margin = new Padding(5)
            };

            // Subscribe to the ButtonClick event
            item.ButtonClick += Item_ButtonClick;

            // Add the panel to the parent panel
            parentPanel.Controls.Add(item);

            // Bring the new panel to the front
            item.BringToFront();
        }

        // Handle the ButtonClick event
        private void Item_ButtonClick(object sender, CustomListItemEventArgs e)
        {
            // Retrieve the data from the event arguments
            string title = e.Title;
            string description = e.Description;
            Image icon = e.Icon;

            // Display the data (for example, in a message box)
            MessageBox.Show($"Button clicked for: {title}\nDescription: {description}");
        }
    }
}

