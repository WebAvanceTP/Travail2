using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2
{
    public class Panier
    {
        private List<Models.Produit> produits;

        public Panier()
        {
            produits = new List<Models.Produit>();
        }

        public void addProduit(Models.Produit produit)
        {
            produits.Add(produit);
        }

        public bool removeProduit(Models.Produit produit)
        {
            return produits.Remove(produit);
        }

        public int getNbrProduits()
        {
            return produits.Count;
        }

        public double getTotal()
        {
            double total = 0.0;
            foreach(Models.Produit prod in produits)
            {
                total += prod.getPrix();
            }
            return total;
        }
    }
}
