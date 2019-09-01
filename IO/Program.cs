using System;
using System.IO;
using System.Text;

namespace IO
{
    class Program
    {
        public static string caminhoArquivo = @"C:\Users\TOTEMTI\Desktop\csharp-projets\CSharpProjets\IO\texto.txt";

        static void Main(string[] args)
        {
            new UsingFileStream().FileStream(caminhoArquivo);
            
            Console.ReadKey();
        }
    }
}
