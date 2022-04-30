using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauculodeMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool v = true;  
            long[,] matriz1 = new long[2,3];
            long[,] matriz2 = new long[3,2];
            long[,] resultado = new long[2,2];
      
            Console.WriteLine("\nPreencha a Matriz 1\n");
         
            for (int linha = 0;linha < 2;linha++)
            {
                for(int coluna = 0;coluna < 3; coluna++)
                {
                    Console.Write($"#1. Posição [{linha}] [{coluna}] : ");
                    var numero = Console.ReadLine();

                    if (numero?.Length > 0)
                        for (int verificar = 0; verificar < numero.Length; verificar++)
                        {
                            if (!char.IsNumber(numero[verificar]))
                            {
                                v = false;
                                Console.Beep();
                            }
                        }
                    else
                        numero = "1";
                    //-------------------------------------------------------
                        if (v == true)
                            matriz1[linha, coluna] = long.Parse(numero);
                        else
                            matriz1[linha, coluna] = 1;
                }
            }
            
            Console.WriteLine("\nPreencha a Matriz 2\n");
  
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write($"#2. Posição [{linha}] [{coluna}] : ");
                    var numero = Console.ReadLine();

                    if (numero?.Length > 0)

                        for (int verificar = 0; verificar < numero.Length; verificar++)
                        {
                            if (!char.IsNumber(numero[verificar]))
                            {
                                v = false;
                                Console.Beep();
                            }
                        }
                    else
                        numero = "1";
                    //-------------------------------------------------------
                    if (v == true)
                        matriz2[linha, coluna] = long.Parse(numero);
                    else
                        matriz2[linha, coluna] = 1;
                }
            }

            Console.WriteLine("\n Resultado da Matriz1 * Matriz2 \n");

            resultado[0,0] = matriz1[0,0] * matriz2[0,0] + matriz1[0,1] * matriz2[1,0] + matriz1[0,2] * matriz2[2,0];
            resultado[1,0] = matriz1[1,0] * matriz2[0,0] + matriz1[1,1] * matriz2[1,0] + matriz1[1,2] * matriz2[2,0];
            resultado[0,1] = matriz1[0,0] * matriz2[0,1] + matriz1[0,1] * matriz2[1,1] + matriz1[0,2] * matriz2[2,1];
            resultado[1,1] = matriz1[1,0] * matriz2[0,1] + matriz1[1,1] * matriz2[1,1] + matriz1[1,2] * matriz2[2,1];

            Console.WriteLine($"[{resultado[0,0]}] [{resultado[1,0]}]");
            Console.WriteLine($"[{resultado[0,1]}] [{resultado[1,1]}]");
           
            Console.ReadKey();
        }
    }
}
