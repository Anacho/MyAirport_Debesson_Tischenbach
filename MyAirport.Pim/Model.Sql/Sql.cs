using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MyAirport.Pim.Entities;
using MyAirport.Pim.Model;

namespace Model.Sql
{
    public class Sql : AbstractDefinition
    {
        private string strcnx =
            ConfigurationManager.ConnectionStrings["MyAirport.Pim.Settings.DbConnect"].ConnectionString;

        private string commandGetBagage =
            "select ID_BAGAGE, COMPAGNIE, LIGNE, DESTINATION, CLASSE, CODE_IATA, EN_CONTINUATION, PRIORITAIRE, JOUR_EXPLOITATION FROM BAGAGE b WHERE b.CODE_IATA = @code";

        private string commandInsertBagage =
            "INSERT INTO BAGAGE (CODE_IATA, COMPAGNIE, LIGNE, CLASSE, DESTINATION, EN_CONTINUATION, PRIORITAIRE, JOUR_EXPLOITATION, DATE_CREATION, ORIGINE_CREATION, ORIGINE_SAFIR, EN_TRANSFERT) " +
            "VALUES (@codeIata, @compagnie, @ligne, @classe, @itineraire, @continuation, @rush, @jourExploit, @dateCreation, @origineCreation, @origineSafir, @enTransfert)";

        public override BagageDefinition GetBagage(string codeIATA)
        {
            using (SqlConnection cnx = new SqlConnection(strcnx))
            {
                BagageDefinition bag = null;
                SqlCommand cmd = new SqlCommand(commandGetBagage, cnx);
                cmd.Parameters.AddWithValue("@code", codeIATA);
                cnx.Open();
                cmd.CommandTimeout = 600;
                #region reader
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    //Au moins un bagage a été trouvé
                    if (reader.Read())
                    {

                        bag = new BagageDefinition();
                        bag.IdBagage = reader.GetFieldValue<int>(reader.GetOrdinal("ID_BAGAGE"));
                        bag.Compagnie = reader.GetFieldValue<string>(reader.GetOrdinal("COMPAGNIE"));
                        bag.Ligne = reader.GetFieldValue<string>(reader.GetOrdinal("LIGNE"));
                        bag.Itineraire = reader.GetFieldValue<string>(reader.GetOrdinal("DESTINATION"));
                        bag.ClasseBagage = reader.GetFieldValue<string>(reader.GetOrdinal("CLASSE"));
                        if (bag.ClasseBagage == null)
                            bag.ClasseBagage = "Y";
                        bag.CodeIata = reader.GetFieldValue<string>(reader.GetOrdinal("CODE_IATA"));
                        bag.Continuation = reader.GetFieldValue<bool>(reader.GetOrdinal("EN_CONTINUATION"));
                        bag.Rush = reader.GetFieldValue<bool>(reader.GetOrdinal("PRIORITAIRE"));
                        bag.JourExploitation = reader.GetFieldValue<short>(reader.GetOrdinal("JOUR_EXPLOITATION"));
                    }
                    if (reader.Read())
                    {
                        throw new ApplicationException("Erreur. Trop de résultats.");
                    }
                }
                #endregion
                cnx.Close();
                return bag;
            }
        }

        public override int CreateBagage(BagageDefinition bag)
        {
            using (SqlConnection cnx = new SqlConnection(strcnx))
            {
                // @dateCreation, @origineCreation, @origineSafir, @enTransfert
                SqlCommand cmd = new SqlCommand(commandInsertBagage, cnx);
                cmd.Parameters.AddWithValue("@codeIata", bag.CodeIata);
                cmd.Parameters.AddWithValue("@compagnie", bag.Compagnie.ToCharArray(0, 3));
                cmd.Parameters.AddWithValue("@ligne", bag.Ligne);
                cmd.Parameters.AddWithValue("@classe", bag.ClasseBagage.ToCharArray(0, 1));
                cmd.Parameters.AddWithValue("@itineraire", bag.Itineraire.ToCharArray(0, 3));
                cmd.Parameters.AddWithValue("@continuation", bag.Continuation);
                cmd.Parameters.AddWithValue("@rush", bag.Rush);
                cmd.Parameters.AddWithValue("@jourExploit", bag.JourExploitation);
                cmd.Parameters.AddWithValue("@dateCreation", DateTime.Now);
                cmd.Parameters.AddWithValue("@origineCreation", "D");
                cmd.Parameters.AddWithValue("@origineSafir", false);
                cmd.Parameters.AddWithValue("@enTransfert", false);

                cnx.Open();

                var nbLignes = cmd.ExecuteNonQuery();
                cnx.Close();
                return nbLignes;
            }
        }

        public override RoutageBagage GetInfoRoutage(int idBagage)
        {
            throw new NotImplementedException();
        }
    }
}
