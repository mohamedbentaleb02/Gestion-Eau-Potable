using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFE
{
    public class PeriodeConsommation
    {
        public PeriodeConsommation(string idMois, string mois)
        {
            this.idMois = idMois;
            this.mois = mois;
        }

        public string idMois { get; set; }
        public string mois { get; set; }
    }
}
