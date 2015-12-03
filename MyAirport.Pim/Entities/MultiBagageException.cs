using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MyAirport.Pim.Entities
{
    [DataContract]
    public class MultiBagageException
    {
        [DataMember] public List<BagageDefinition> resBagages;
        [DataMember] public string CodeIATA;
        [DataMember] public string ErrorMessage;
    }
}   