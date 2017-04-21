using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ReadJson
{
        [DataContract]
        public class JsonItem
        {
            [DataMember(Name = "ref")]
            public bool Ref { get; set; }
        }
}
