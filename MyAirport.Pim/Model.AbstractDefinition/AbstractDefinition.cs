using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAirport.Pim.Entities;

namespace MyAirport.Pim.Model
{
    public abstract class AbstractDefinition
    {
        public abstract Entities.BagageDefinition GetBagage(string codeIATA);
        public abstract int CreateBagage(BagageDefinition bag);

        public abstract Entities.RoutageBagage GetInfoRoutage(int idBagage);
    }
}
