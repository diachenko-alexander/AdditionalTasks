using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTaskSerialise.Interfaces
{
    interface IMySerialise<T>
    {
        string Serialize<T> (T list);
        object Deserialise(string s);

    }
}
