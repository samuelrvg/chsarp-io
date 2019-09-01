using System;
using System.IO;
using System.Text;

namespace IO
{
    public class UsingFileStream
    {
        public void FileStream(string caminhoArquivo)
        {
            FileStream fs = new FileStream(caminhoArquivo, FileMode.Open);

            var bytes = new byte[1024];

            var bytesRead = fs.Read(bytes, 0, bytes.Length);

            ShowText(bytes);
        }

        public static void ShowText(byte[] bytes)
        {
            var utf8 = UTF8Encoding.UTF8;

            var text = utf8.GetString(bytes, 0, bytes.Length);

            Console.WriteLine(text);
        }
    }
}
