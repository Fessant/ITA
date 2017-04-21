using System;
using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ReadJson
{
    [DataContract]
    public class Error
    {
        [DataMember(Name = "type")]
        public string [] Types { get; set; }

        [DataMember(Name = "items")]
        public  JsonItem Item { get; set; }
         
    }
}