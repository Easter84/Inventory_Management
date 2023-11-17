namespace HW6_Inventory
{

    public partial class AddItem : Form
    {

        public AddItem()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Instantiates the InventoryItem class as newItem
        /// </summary>
        public InventoryItem newItem { get; set; } = new();

        /// <summary>
        /// Creates an instance of InventoryItem and loads the proper data into it then, passes it back to MainForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            newItem.Name = this.NameTextBox.Text;
            newItem.Description = this.DescriptionTextBox.Text;
            newItem.Price = Convert.ToDecimal(this.PriceTextBox.Text);
        }

        /// <summary>
        /// Closes the current form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
