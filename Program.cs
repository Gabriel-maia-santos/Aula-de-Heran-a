using System;

namespace Aula_de_eranca
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Cpf cpf = new Cpf();
           cpf.nome = "Gabriel";
           Console.WriteLine(cpf.Saudar());

           cpf.cpf = "000.000.000-00";
           Console.WriteLine(cpf.ValidarCPF());
        }
    }
}
