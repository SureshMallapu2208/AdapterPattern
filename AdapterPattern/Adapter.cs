using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class Adapter : IExport
    {
        public void Export(string path)
        {
            ThirdParty thirdParty = new ThirdParty();
            thirdParty.Save();
        }
    }
}
