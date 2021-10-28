using System;
using System.Collections.Generic;

namespace Salario
{
    class Program
    {
        //declaraçã ode variavel
        static string s1, s2;
        private static string nome;
        private static string salario;

        static void Main(string[] args)
        {
            int n = 0;
            //identificão de quantos usuarios serão criados
            Console.Write("Quantos usuarios serão criados:");
            n = int.Parse(Console.ReadLine());
            //criação da lista
            List<string> list = new List<string>();
            //for para gerar as listas agrupadaa
            for ( int i = 1; i <= n; i++)
            {
                //Informa a lista
                list = new List<string>();
                //Informações de dentro da lista
                Console.WriteLine("Funcionario #" + i);
                Console.WriteLine("ID 00" + i);
                string nn = i.ToString();
                list.Add(nn);
                Console.Write("nome: ");
                nome = Console.ReadLine();
                list.Add(nome);
                Console.WriteLine("Salário: ");
                salario = Console.ReadLine();
                list.Add(salario);


            }
            //nforma o id do usuario criado:
            Console.WriteLine("Id do usuario receberá aumento: ");
            int num = int.Parse(Console.ReadLine());
            //foreach para passar na ista
            foreach (var i in list)
            {
                //pegando valor de Indice
                s1 = list.Find(nn => nn[0] == num);
                //pegando valor de salario
                s2 = list.Find(sal => sal[0] == num);
            }

            //atribuição da porcentagem
            Console.WriteLine("porcentagem de aumento de salario: ");
            double por = double.Parse(Console.ReadLine());
            por = por / 100;
            double ss2 = Convert.ToDouble(s2);
            double cento = ss2 * por;
            double total = ss2 + cento;
            //impressão final
            Console.WriteLine("Posição: " + s1);
            Console.WriteLine("Salario total: " + ss2);




          
        }
    }
}
