using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //==============================================================================================
            //==============================================================================================
            //==============================================================================================
            /*
            *    Dada um texto A "Talita le uma canção em voz alta no caminho"
            *    e uma array de textos B
            *    - "uma canç"
            *    - "em vo"
            *    - "alta no cam"
            *     retorne no console um conjunto de C que contenha todo o texto de A sem as palavras do B
            *     
            */

            string A = "Talita le uma cancao em voz alta no caminho";
            Console.WriteLine(A);
            List<string> B = new List<string>() { " uma canc", " em vo", " alta no cam" };
            B.ForEach(palavra => Console.WriteLine(palavra));
            string C = "";

            // Faça seu código aqui

            Console.WriteLine(C);
            if (C.Equals("Talita leaozinho")) Console.Write("CORRETO!\n\n");
            Console.ReadLine();

            //==============================================================================================
            //==============================================================================================
            //==============================================================================================
            /*
             * O mundo esta sendo atacado por zuumbis
             * para salvar o mundo é necessario descobrir o zumbi de origem, 
             * que começou a infecção
             * Foi elaborada uma tabela que mostra qual zumbi originou qual
             * Elabore um codigo que descubra, atravez da tabela quantos 
             * zumbis de origem tem numa tabela
             * EX 1:
            //	  	1   2   3   4
            //	 1  X       X
            //	 2      X       X
            //	 3      X   X
            //	 4              X
            //	Resp: 1
             * 
             * O zumbi 1 mordeu o numero 3
             * O zumbi 3 mordeu o numero 2
             * O zumbi 2 mordeu o numero 4
             * O zumbi 4 não mordeu ninguém
             * 
             * sendo assim a origem é 1 >> 3 >> 2 >> 4
             * Reposta,, uma unica origem, o zumbi um é pai de todos
             * 
             * Ex 2:
            //
            //	 	1   2   3   4
            //	 1  X   X
            //	 2      X
            //	 3          X
            //	 4          X   X
            //	Resp: 2
            * 
             * O zumbi 1 mordeu o numero 2
             * O zumbi 2 não mordeu ninguém
             * O zumbi 3 não mordeu ninguém
             * O zumbi 4 mordeu o numero 3
             * 
             * sendo assim a origem é 1 >> 2 e outra origem é 4 >> 3
             * Reposta, duas origems, o zumbi 1 e zumbi 4
             * 
             *   * Ex 3:
            //
            //	 	1   2   3   4
            //	 1  X   
            //	 2      X
            //	 3          X
            //	 4              X
            //	Resp: 4
            * 
             * O zumbi 1 não mordeu ninguém
             * O zumbi 2 não mordeu ninguém
             * O zumbi 3 não mordeu ninguém
             * O zumbi 4 não mordeu ninguém
             * 
             * sendo assim cada zumbi originou a si proprio
             * Reposta, quatro origems
             * 
            */

            bool[][] Z = {
                new bool[] { true, false , false , false },
                new bool[] { false, true , false , false },
                new bool[] { false, false , true, true },
                new bool[] { true, true , false , true}
            };

            int numOrigens = 4;
            // Faça seu código aqui

            Console.WriteLine("O numero de origens é " + numOrigens);
            Console.ReadLine();

            //==============================================================================================
            //==============================================================================================
            //==============================================================================================
            /*
             * Faça um codigo que determine se os brackets são simetricos, ou seja
             * se para cada bracket aberto, seja ( ou ( ou { existe um correspondente 
             * após que fecha o mesmo
             *  
             *  Ex 1: "[{}[])]"
             *  Resp: "Não é simétrico"
             *  
             *  Ex 1: "[{}([])]"
             *  Resp: "Simétrico"
             *  
             *  Ex 1: "[{}({[])]"
             *  Resp: "Não é simétrico"
             */

            string b = "[{}[])]";
            bool s = false;

            // Faça seu código aqui

            Console.WriteLine(s ? "Simétrico" : "Não é simétrico");
            Console.ReadLine();

            //==============================================================================================
            //==============================================================================================
            //==============================================================================================
            /*
             * 
             *               
             */


        }

        
    }
}








