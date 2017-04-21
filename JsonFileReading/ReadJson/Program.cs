using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace ReadJson
{
    class Program
    {
        static void Main(string[] args)
        {
           string fileText = File.ReadAllText(@"..\..\source.json"); //Deserialization JSON file 
            SourceJson element = JsonConvert.DeserializeObject<SourceJson>(fileText);

            string serializedElement = JsonConvert.SerializeObject(element); // Serialization JSON File 
            File.WriteAllText(@"..\..\new_json.json", serializedElement);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(SourceJson));
            xmlSerializer.Serialize(new FileStream(@"..\..\source.xml", FileMode.OpenOrCreate), element);

            Console.WriteLine("Tadaaaam");
            Console.ReadLine();

        }
    }
}
