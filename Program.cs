using System;

namespace Desafio01
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            int num = 0;
            int soma = 0;
            Console.WriteLine("------Desafio 01------");
            Console.WriteLine("Digite um Numero:");
            num = int.Parse(Console.ReadLine());

            for (int numero = 0; numero <= num; numero++)
            {
                if (numero % 2 != 0)
                {
                    if (numero % 3 == 0 && numero % 5 == 0)
                    {
                        soma += numero;

                    }
                }
               
           
            }
            Console.WriteLine("O resultado total é: {0}\n", soma);
            Console.Write("PRESSSIONE ALGUMA TECLA PARA SAIR!");
            Console.ReadKey();
        }
    }
}
