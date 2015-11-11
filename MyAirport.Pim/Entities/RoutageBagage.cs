namespace MyAirport.Pim.Entities
{
    public class RoutageBagage
    {
        public int LocalisationEjection { get; set; }
        public string NomEjection { get; set; }
        public string StatutEjection { get; set; }
        
        public int LocalisationSureteN1 { get; set; }
        public string NomSureteN1 { get; set; }

        public int LocalisationSuretetN3 { get; set; }
        public string NomSureteN3 { get; set; }
    }
}