using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFE
{
    public class Nbrpolice
    {

        public Nbrpolice(string id, string nbrPolice)
        {
            this.id = id;
            this.nbrPolice = nbrPolice;
        }

        public string id { get; set; }
        public string nbrPolice { get; set; }
    }
}
