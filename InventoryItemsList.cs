using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HW6_Inventory
{/// <summary>
/// A class to create, modify and utilize a list of inventory objects.
/// </summary>
    public class InventoryItemsList
    {
        // Creating the internal Class list
        private List<InventoryItem> items = new();

        // Creating the public Class List
        public List<InventoryItem> Items => this.items;

        /// <summary>
        /// A method to fill the list prior to instantiating it, then
        /// creating the list object
        /// </summary>
        /// <param name="file"></param>
        /// <returns>object list</returns>
        public static InventoryItemsList NewInstance(string file)
        {
            var list = new InventoryItemsList();
            using (var reader = new StreamReader(file))
            {
                var line = reader.ReadLine();
                list.Items.Add(InventoryItem.NewInstance(line));
            }
            return list;
        }


        /// <summary>
        /// A method to save the list to a csv file.
        /// </summary>
        /// <param name="file"></param>
        public void Save(string file)
        {
            using (var writer = new StreamWriter(file))
            {
                foreach (var item in this.Items)
                {
                    writer.WriteLine(item.FileString);
                }
            }
        }
    }
}
