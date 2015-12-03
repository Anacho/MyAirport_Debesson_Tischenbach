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
        public BagageDefinition GetBagageById(int idBagage)
        {
            throw new NotImplementedException();
        }

        public BagageDefinition GetBagageByCodeIata(string codeIata)
        {
            List<BagageDefinition> res = null;

            try
            {
                res = Factory.Model.GetBagage(codeIata);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                throw new FaultException("Erreur erreur s'est produite dans le traitement de la requête.");
            }
            if (res != null && res.Count > 0)
            {
                if (res.Count == 1)
                {
                    return res[0];
                }
                else
                {
                    MultiBagageException mbe = new MultiBagageException
                    {
                        CodeIATA = codeIata,
                        resBagages = res,
                        ErrorMessage = "Plusieurs bagages ont été trouvés."
                    };
                    throw new FaultException<MultiBagageException>(mbe);
                }
            }
            return null;
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
