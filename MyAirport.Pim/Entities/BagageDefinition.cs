using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAirport.Pim.Entities
{
    sealed public class BagageDefinition
    {
        public int IdBagage { get; set; }
        public string CodeIata { get; set; }
        public string Compagnie { get; set; }
        public string Ligne { get; set; }
        public char LigneAlpha { get; set; }
        public DateTime DateVol { get; set; }
        public string Itineraire { get; set; }
        public string ClasseBagage { get; set; }
        public bool Continuation { get; set; }
        public bool Rush { get; set; }
        public short JourExploitation { get; set; }
    }
}
