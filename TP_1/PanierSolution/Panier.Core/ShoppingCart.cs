using System;
using System.Collections.Generic;
using System.Text;

namespace Panier.Core
{
    public sealed class ShoppingCart
    {

        private List<CartItem> items = new List<CartItem>();

        private decimal discountValue = 0;

        private bool discountAleadyApplied = false;
        

        public int GetItemCount() => items.Count;
        
        public void AddItem(string name, decimal price, int quantity)
        {
            if (name is null) throw new ArgumentNullException("Le nom ne peut pas etre null");

            if (price <= 0) throw new ArgumentException("Le prix doit etre plus grand que 0");

            if (quantity <= 0) throw new ArgumentException("La quantité doit etre plus grande que 0");

            var existingItem = items.Find(x => x.Name == name);

            if (existingItem != null)
            {
                if(existingItem.Price != price)
                {
                    throw new InvalidOperationException($"Un article ({name}) existe et avec un prix different.");
                } else
                {
                    existingItem.Quantity += quantity;
                }
            } 
            else
            {
                CartItem newItem = new CartItem(name, price, quantity);
                items.Add(newItem);
            }
        }

        public decimal GetTotal() => items.Aggregate(0m, (total, current) => total += current.Price * current.Quantity) * (1 - discountValue);
        
        public void ApplyDiscount(decimal percentage)
        {
            if (discountAleadyApplied) throw new ArgumentException("Une remise a deja été appliquée");

            if (GetItemCount() == 0) throw new ArgumentException("Une remise ne peut pas etre appliquée sur un panier vide.");

            if (percentage < 0) throw new ArgumentException("Une remise ne peut pas etre négative.");

            if (percentage > 100) throw new ArgumentException("Une remise ne peut pas etre superieur à 100%.");

            this.discountValue = percentage / 100m;
            this.discountAleadyApplied = true;
        }

        public void ResetDiscount()
        {
            this.discountAleadyApplied = false;
            this.discountValue = 0;
        }
    }
}
