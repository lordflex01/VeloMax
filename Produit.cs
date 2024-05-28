using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeloMax
{
    public class Produit
    {
        public int IDPRODUIT { get; set; }
        public string DESCRIPTION { get; set; }
        public string DELAIAPPROV { get; set; }
        public string NOM { get; set; }
        public float NUMEROPRODUIT { get; set; }
        public float PRIX { get; set; }
        public Date DATEPRODUCTION { get; set; }
        public Date DATEFIN { get; set; }

        public Produit() { }


    }
}
