using System;
using System.Runtime.Serialization;

namespace MyAirport.Pim.Entities
{
    [DataContract]
    sealed public class BagageDefinition
    {
        [DataMember]
        public int IdBagage { get; set; }

        [DataMember]
        public string CodeIata { get; set; }

        [DataMember]
        public string Compagnie { get; set; }

        [DataMember]
        public string Ligne { get; set; }

        [DataMember]
        public char LigneAlpha { get; set; }

        [DataMember]
        public DateTime DateVol { get; set; }

        [DataMember]
        public string Itineraire { get; set; }

        [DataMember]
        public string ClasseBagage { get; set; }

        [DataMember]
        public bool Continuation { get; set; }

        [DataMember]
        public bool Rush { get; set; }

        [DataMember]
        public short JourExploitation { get; set; }
    }
}
