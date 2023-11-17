using System.Windows.Forms.VisualStyles;

namespace HW6_Inventory
{/// <summary>
/// This is the main form that covers seeing an inventory list, and allows
/// access to editing it and open/save funtions as well as closing the program.
/// </summary>
    public partial class MainForm : Form
    {
        // Creating an instance of the InventoryItems class to store the objects.
        public InventoryItemsList InventoryItems { get; set; } = new();

        // Creating an instance of InventoryItem class for getting data from AddItem form
        public InventoryItem newItem { get; set; } = new();

        public MainForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Opens a csv file from a user selected location and the imports it into an InventoryItemsList object
        /// then displays it to the DisplayListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenButton_Click(object sender, EventArgs e)
        {
            this.DisplayListBox.Items.Clear();
            using (var dialog = new OpenFileDialog())
            {
                // Setting the initial directory for the dialog box
                dialog.InitialDirectory = @"c:\";
                // Setting the filter to only display csv files
                dialog.Filter = "csv file (*.csv)|*.csv";
                dialog.RestoreDirectory = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.InventoryItems =
                        InventoryItemsList.NewInstance(dialog.FileName);
                }
            }
            foreach (var item in InventoryItems.Items)
            {
                this.DisplayListBox.Items.Add(item.FileString);
            }
        }

        /// <summary>
        /// Closes the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Opens teh AddItem form to allow for the user to input a new product. 
        /// And gets the product as a InventoryItem. Dispalys it and adds it to the 
        /// InventoryItemsList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            var addItem = new AddItem();
            var result = addItem.ShowDialog();

            if (result == DialogResult.OK)
            {
                newItem = addItem.newItem;
                this.DisplayListBox.Items.Add(newItem.FileString);
                this.InventoryItems.Items.Add(newItem);
            }
        }

        /// <summary>
        /// Opens a save dialog box to allow the user to create a csv document regarding their current 
        /// inventory list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                // Sets the starting Directory to the C drive.
                dialog.InitialDirectory = @"c:\";
                // Limits the search bar in the dialog box to csv file type
                dialog.Filter = "csv files (*.csv)|*.csv";
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.InventoryItems.Save(dialog.FileName);
                } // else the user did not selecte a file DoNothing();
            }

        }

        /// <summary>
        /// Removes an item from the listbox that is selected by the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var item = this.DisplayListBox.SelectedItem;
            this.DisplayListBox.Items.Remove(item);
        }
    }
}