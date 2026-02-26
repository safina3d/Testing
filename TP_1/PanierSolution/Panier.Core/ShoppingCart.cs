using System;
using System.Collections.Generic;
using System.Text;

namespace Panier.Core
{
    public sealed class ShoppingCart
    {

        private List<CartItem> items = new List<CartItem>();

        private decimal discountValue = 0;

        public int GetItemCount() => items.Count;
        
        public void AddItem(string name, decimal price, int quantity)
        {
            if (name is null) throw new ArgumentNullException("Le nom ne peut pas etre null");

            if (price <= 0) throw new ArgumentException("Le prix doit etre plus grand que 0");

            if (quantity <= 0) throw new ArgumentException("La quantité doit etre plus grande que 0");

            CartItem newItem = new CartItem(name, price, quantity);
            items.Add(newItem);
        }

        public decimal GetTotal() => items.Aggregate(0m, (total, current) => total += current.Price * current.Quantity) * (1 - discountValue);
        
        public void ApplyDiscount(decimal percentage)
        {
            if (GetItemCount() == 0) throw new ArgumentException("Une remise ne peut pas etre appliquée sur un panier vide.");

            if (percentage < 0) throw new ArgumentException("Une remise ne peut pas etre négative.");

            this.discountValue = percentage / 100m;
        }
    }
}
