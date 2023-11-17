using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HW6_Inventory
{
    /// <summary>
    /// This class models a piece of inventory, assigning name, description and price to it.
    /// </summary>
    public class InventoryItem
    {
        // Setting a public get/set for name
        public string Name { get; set; }

        // Setting a public get/set for description
        public string Description { get; set; }

        // Setting a public get/set for price
        public decimal Price { get; set; }

        /// <summary>
        /// This is a static method to parse a string into a new inventory item.
        /// </summary>
        /// <param name="line"></param>
        /// <returns> inventoryItem </returns>
        public static InventoryItem NewInstance(string line)
        {
            var inventoryItem = new InventoryItem();
            // Loops over the string and splits it then assigns the property to the needed index.
            foreach (var word in line)
            {
                var tokens = line.Split(',');
                inventoryItem.Name = tokens[0];
                inventoryItem.Description = tokens[1];
                inventoryItem.Price = Convert.ToDecimal(tokens[2]);
            }
            return inventoryItem;
        }

        /// <summary>
        /// A static method to add a new item as a InventoryItem object
        /// </summary>
        /// <param name="name"></param>
        /// <param name="desc"></param>
        /// <param name="price"></param>
        /// <returns> newItem </returns>
        public static InventoryItem NewItem(string name, string desc, decimal price)
        {
            var newItem = new InventoryItem();
            newItem.Name = name;
            newItem.Description = desc;
            newItem.Price = price;

            return newItem;
        }

        /// <summary>
        /// Creates a string that will be called for display or saving.
        /// </summary>
        public string FileString =>
            $"{this.Name}, {this.Description}, {this.Price}";

    }
}
