using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAirport.Pim.Entities;
using MyAirport.Pim.Model;

namespace MyAirport.Pim.Model
{
    public class Natif : AbstractDefinition
    {
        public override BagageDefinition GetBagage(string codeIATA)
        {
            return null;
        }

        public override int CreateBagage(BagageDefinition bag)
        {
            throw new NotImplementedException();
        }

        public override RoutageBagage GetInfoRoutage(int idBagage)
        {
            return new RoutageBagage()
            {
                LocalisationEjection = 4516,
                NomEjection = "EJ13",
                StatutEjection = "TPS",
                LocalisationSureteN1 = 4385,
                NomSureteN1 = "PIM EST",
                LocalisationSuretetN3 = 13284,
                NomSureteN3 = "CX1"
            };
        }
    }
}
