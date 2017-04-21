using System.Data.Common;
using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadJson
{
    [DataContract]
    public class Tier
    {
        [DataMember(Name = "type")]
         public int Number { get; set; }
    }
}