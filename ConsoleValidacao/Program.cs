using ConsoleValidacao.Helpers;
using System;

namespace ConsoleValidacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf;

            do
            {
                Console.Write("Para sair escreva 'sair'\n\n");

                Console.Write("Insira o CPF: ");
                cpf = Console.ReadLine();

                Console.Write("CPF é válido? {0}\n\n\n", Validacao.CPFisValid(cpf));
            }
            while (cpf != "sair"); 
        }
    }
}
