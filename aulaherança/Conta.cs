using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaherança
{     //Criação da classe Conta

    
    public class Conta
    {
     

            //Declarações das variáveis e uso do encapsulamento
            public int Numero { get; private set; }
            public string Titular { get; private set; }
            //Utilização do protected para alteração de valores entre classes
            public double Saldo { get; protected set; }
            public double SaldoTotal { get; private set; }

        //Criação do construtor padrão e construtor com parâmetros
        public Conta() { }
        public Conta(int numero, string titular, double saldo, double saldoTotal)
            {
                Numero = numero; Titular = titular; Saldo = saldo;
            }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        //Método de Saque
        public  void Saque(double SaldoTotal)
            {
            SaldoTotal = SaldoTotal - Saldo;
            }
            //Método de Deposito
            public void Deposito(double SaldoTotal)
            {
            SaldoTotal = SaldoTotal + Saldo;
            }
        }       
        
    }
 

        
    

