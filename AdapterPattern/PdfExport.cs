
namespace AdapterPattern
{
    public class PdfExport : IExport
    {
        public void Export(string path)
        {
            Console.WriteLine($" PDF Exported Successfully");
        }
    }
}
