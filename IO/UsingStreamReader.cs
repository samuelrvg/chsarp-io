using System;
using System.IO;
using System.Text;

namespace IO
{
    public class UsingStreamReader
    {
        public void StreamReader(string camingoArquivo)
        {
            using (var fs = new FileStream(camingoArquivo, FileMode.Open))
            using (var sr = new StreamReader(fs, Encoding.UTF8))
            {
                string text = "";

                while (!sr.EndOfStream)
                {
                    text += sr.ReadLine();
                }

                //text = sr.ReadToEnd();

                Console.WriteLine(text);
            }
        }
    }
}
