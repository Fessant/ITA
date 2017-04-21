using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ReadJson
{
    [DataContract]
    public class SourceJson
    {
        [DataMember(Name = "type")]
        public string Type { get; set; }
        [DataMember(Name = "properties")]
        public Properties Properties { get; set; }
        
    }
}
