using System;
namespace MyShop.Models
{
    public class ShopItem
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        

        public ShopItem(string name, string description, int price, int quantity)
        {
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
        }
    }
}
