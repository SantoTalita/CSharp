using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace SystemIOConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mensagem que vai para o terminal");
            TextReader leitor = Console.In;
            string linha = leitor.ReadLine();
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = leitor.ReadLine();
            }
            leitor.Close();
        }
    }
}
