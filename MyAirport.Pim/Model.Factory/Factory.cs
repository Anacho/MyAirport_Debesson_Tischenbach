using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Sql;
using MyAirport.Pim.Model;

namespace MyAirport.Pim.Model
{
    public class Factory
    {
        private static AbstractDefinition _singleton = null;

        public static AbstractDefinition Model
        {
            get
            {
                if (_singleton == null)
                {
                    switch (ConfigurationManager.AppSettings["Factory"])
                    {
                        case "Sql":
                            _singleton = new Sql();
                            break;
                        case "Natif":
                            _singleton = new Natif();
                            break;
                        default:
                            _singleton = new Sql();
                            break;
                    }
                }
                return _singleton;
            }
        }
    }
}
