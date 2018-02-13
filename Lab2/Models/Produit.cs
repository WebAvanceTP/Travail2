using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class Produit
    {
        private double prix;
        private string nom;
        private string description;
        private string imgSrc;

        public Produit(double _prix = 0.0, string _nom = "", string _description = "", string _imgSrc = "")
        {
            prix = _prix;
            nom = _nom;
            description = _description;
            imgSrc = _imgSrc;
        }

        public double getPrix()
        {
            
            return prix;

        }
    }
}
