using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class ExcelExport : IExport
    {
        public void Export(string path)
        {
            Console.WriteLine($"Excell Exported Successfully");
        }
    }
}
