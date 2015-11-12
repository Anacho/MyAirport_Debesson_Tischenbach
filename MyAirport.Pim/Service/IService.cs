using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MyAirport.Pim.Entities;

namespace MyAirport.Serveur
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        BagageDefinition GetBagageById(int idBagage);

        [OperationContract]
        BagageDefinition GetBagageByCodeIata(string codeIata);

        [OperationContract]
        int CreateBagage(BagageDefinition bagage);

        [OperationContract]
        RoutageBagage GetInfoRoutage(int idBagage);
    }
}
