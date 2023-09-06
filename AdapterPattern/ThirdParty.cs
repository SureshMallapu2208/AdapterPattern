using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class ThirdParty
    {
        public void Save()
        {
            Console.WriteLine($"ThirdParty Exported Successfully");
        }
    }
}
