using System;
using Banco.Exercicio.Classe;
using System.Globalization;

namespace Banco.Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta(0, null, 0.00, 0.00);

            Console.WriteLine("Entre o número da conta: ");
            int v = int.Parse(Console.ReadLine());
            c._conta = v;

            Console.WriteLine("Entre o titular da conta: ");
            string w =Console.ReadLine();
            c._nome = w;

            Console.WriteLine("Haverá depósito inicial (s/n)? ");
            string resposta = Console.ReadLine();
            c.resposta = resposta;

            if(resposta != "n"){
                Console.WriteLine("Digite o valor de depósito inicial: ");
                double d = double.Parse(Console.ReadLine());
                c._saldo =c._saldo + d; 
            }

            Console.WriteLine($"Conta: {c._conta}");
            Console.WriteLine($"Titular: {c._nome}");
            Console.WriteLine($"Valor em conta: R$ {c._saldo}");  
            Console.ReadLine();
            
        }
    }
}
