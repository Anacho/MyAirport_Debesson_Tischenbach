using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MyAirport.Pim.Entities;
using MyAirport.Pim.Model;

namespace MyAirport.Serveur
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class Service : IService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public BagageDefinition GetBagageById(int idBagage)
        {
            throw new NotImplementedException();
        }

        public BagageDefinition GetBagageByCodeIata(string codeIata)
        {
            return Factory.Model.GetBagage(codeIata);
        }

        public int CreateBagage(BagageDefinition bagage)
        {
            return Factory.Model.CreateBagage(bagage);
        }

        public RoutageBagage GetInfoRoutage(int idBagage)
        {
            return Factory.Model.GetInfoRoutage(idBagage);
        }
    }
}
