using System;
using System.Globalization;

namespace Dadospessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            //chamas as classes
            pessoa x;
            x = new pessoa();

            pessoa y;
            y = new pessoa();

            //atribui as variaves das classe
            Console.WriteLine("-----------Entre com as informações da  primeira pessoa: ");
            Console.Write("Idade : ");
            x.idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nome : ");
            x.nome = (Console.ReadLine());

            Console.WriteLine("-----------Entre com as informações da  segunda pessoa : ");
            Console.Write("Idade : ");
            y.idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nome : ");
            y.nome = (Console.ReadLine());
           
            //imprimi informações na tela;
            Console.WriteLine("--------informações da  primeira pessoa-------------");
            Console.WriteLine("O nome  é :" + x.nome);
            Console.WriteLine(" A idade dele é : " + x.idade.ToString(CultureInfo.InvariantCulture));

            Console.WriteLine("--------informações da  segunda pessoa----------");
            Console.WriteLine("O nome  é :" + y.nome);
            Console.WriteLine("A idade dele  é : " + y.idade.ToString(CultureInfo.InvariantCulture));
            //verifica qual é o mais velho e some;
            if (x.idade > y.idade)
            {
                Console.WriteLine("A primeria pessoa é o mais nova");
            }
            else
            {
                Console.WriteLine("A segunda pessoa é o mais velha");
            }



        }
    }
}
