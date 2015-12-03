using System;
using System.Runtime.Serialization;

namespace MyAirport.Pim.Entities
{
    [DataContract]
    public class RoutageBagage
    {
        [DataMember]
        public int LocalisationEjection { get; set; }

        [DataMember]
        public string NomEjection { get; set; }

        [DataMember]
        public string StatutEjection { get; set; }

        [DataMember]
        public int LocalisationSureteN1 { get; set; }

        [DataMember]
        public string NomSureteN1 { get; set; }

        [DataMember]
        public int LocalisationSuretetN3 { get; set; }

        [DataMember]
        public string NomSureteN3 { get; set; }
    }
}