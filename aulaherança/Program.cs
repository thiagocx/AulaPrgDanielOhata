using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaherança
{
    class Program
    {
        static void Main(string[] args)
        {
           


            //Conta conta1 = new Conta;
            Console.WriteLine("Saldo da conta: ");
           double saldo = double.Parse(Console.ReadLine());
            Console.WriteLine("Nome do Titular: ");
           string Titular = (Console.ReadLine());
            Console.WriteLine("Emprestimo maximo liberado: ");
            double EmprestimoLimite = double.Parse(Console.ReadLine());

            ContaJuridica conta = new ContaJuridica(0, Titular, saldo, EmprestimoLimite);
            Console.WriteLine("conta: " + conta.Saldo);
            Console.WriteLine("titular: " + conta.Titular);
            Console.WriteLine("emprestimo limite: " + conta.EmprestimoLimite);


            Console.WriteLine("----CONTA POUPANÇA----");
            Console.WriteLine("Taxa poupança: ");
            double taxaJuros = double.Parse(Console.ReadLine());
            //Console.WriteLine("Informe o valor a ser debitado: ");
           // double saldoT = double.Parse(Console.ReadLine());




            ContaPoupanca contapon = new ContaPoupanca(0,Titular,saldo,taxaJuros);
            Console.WriteLine("conta: " + contapon.Saldo);
            Console.WriteLine("titular: " + contapon.Titular);
            Console.WriteLine("taxa do juros: : "+ contapon.TaxaJuros);
            Console.WriteLine("saldo total existente : " + contapon.SaldoTotal);
            Console.ReadKey();




            /*ContaJuridica conta = new ContaJuridica(8010,"LaraCroft", 100.0, 500.0);
            Console.WriteLine(conta.Saldo);
            */
        }
    }
}
