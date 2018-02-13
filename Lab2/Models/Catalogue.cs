using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class Catalogue
    {
        private List<Models.Produit> produits;

        public Catalogue()
        {
            produits = new List<Models.Produit>();
        }

        public List<Models.Produit> getProduits()
        {
            
            return produits;
        }
    }
}
