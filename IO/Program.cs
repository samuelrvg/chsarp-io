using System;

namespace IO
{
    class Program
    {
        public static string caminhoArquivo = @"C:\Users\TOTEMTI\Desktop\csharp-projets\CSharpProjets\IO\texto.txt";
        public static string caminhoArquivoCriar = @"C:\Users\TOTEMTI\Desktop\csharp-projets\CSharpProjets\IO\texto2.txt";

        static void Main(string[] args)
        {
            //new UsingFileStream().FileStream(caminhoArquivo);

            //new UsingStreamReader().StreamReader(caminhoArquivo);

            new UsingStreamWrite().StreamWrite(caminhoArquivoCriar);

            Console.ReadKey();
        }
    }
}
