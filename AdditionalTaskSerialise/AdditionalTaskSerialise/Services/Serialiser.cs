using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace AdditionalTaskSerialise.Services
{
    class Serialiser : Interfaces.IMySerialise<User>
    {
        public string Serialize<User>(User list)
        {
            return JsonConvert.SerializeObject(list, Formatting.Indented);
        }

        public object Deserialise(string s)
        {
            return JsonConvert.DeserializeObject<List<User>>(s);
            
        }

        
    }
}
