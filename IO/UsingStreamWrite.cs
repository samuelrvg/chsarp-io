using System.IO;
using System.Text;

namespace IO
{
    public class UsingStreamWrite
    {
        public void StreamWrite(string caminhoArquivo)
        {
            using (FileStream fs = new FileStream(caminhoArquivo, FileMode.CreateNew))
            using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
            {
                sw.Write("texto de teste stream writer");
            }
        }
    }
}
