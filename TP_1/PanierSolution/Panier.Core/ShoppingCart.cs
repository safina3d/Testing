using System;
using System.Collections.Generic;
using System.Text;

namespace Panier.Core
{
    public sealed class ShoppingCart
    {
        private List<CartItem> items = new List<CartItem>();

        public int GetItemCount() => items.Count;
        
        public void AddItem(string name, decimal price, int quantity)
        {
            CartItem newItem = new CartItem(name, price, quantity);
            items.Add(newItem);
        }

        public decimal GetTotal() => items.Aggregate(0m, (total, current) => total += current.Price * current.Quantity);
        
        public void ApplyDiscount(decimal percentage)
        {
            if (GetItemCount() == 0) throw new ArgumentException("Une remise ne peut pas etre appliquée sur un panier vide.");
        }
    }
}
