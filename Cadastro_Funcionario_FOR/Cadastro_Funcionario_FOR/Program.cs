using System;

namespace Cadastro_Funcionario_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de funcionários:\n");
            int NumFunc=int.Parse(Console.ReadLine());

            for(int i =0; NumFunc>=i; i++)
            {
                Console.WriteLine("\nNome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("\nIdade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine("\nSexo: ");
                char s = char.Parse(Console.ReadLine());

                if(s=='M' || s == 'm')
                {
                    Console.WriteLine("Contratado para estoque");
                }

                else
                {
                    Console.WriteLine("Contratada para caixa");
                }

            }
        }
    }
}
