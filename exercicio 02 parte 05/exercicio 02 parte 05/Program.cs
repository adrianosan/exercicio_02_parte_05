using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_02_parte_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero = 0;
            int soma, multiplicacao , divisao;
            int segundoNumero = 0;
            
            Console.Write("Digite o primeiro número. ");
            primeiroNumero = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número. ");
            segundoNumero = int.Parse(Console.ReadLine());

            soma = primeiroNumero + segundoNumero;
            Console.WriteLine("A soma dos dois numero é: {0}" , soma);

            multiplicacao = primeiroNumero * segundoNumero;
            Console.WriteLine("A multiplicação dos dois numero é:{0}", multiplicacao);

            divisao = primeiroNumero / segundoNumero;
            Console.WriteLine(" A divisao dos dois numero é:{0}", divisao);
            




               

           
        

        }
    }
}
