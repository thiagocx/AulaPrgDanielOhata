using System;

namespace hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda[] vect = new Agenda[10];

            Console.WriteLine("Quantos hospesdes agendados: ");//n° de hospedes agendados
            int n = int.Parse(Console.ReadLine());//leitura dos dados

            for (int i = 1; i <= n; i++)//loop de leitura
            {
                Console.WriteLine();
                Console.WriteLine($"Cliente #{i}");
                Console.Write("Nome:");
                string nome = Console.ReadLine(); //leitura de dados
                Console.Write("Email:");
                string email = Console.ReadLine();//leitura de dados
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());//leitura de dados
                vect[quarto] = new Agenda(nome, email);// atriabuindo valor aos propeties
            }
            //zone de impressão
            Console.WriteLine();
            Console.WriteLine("-----------------Quartos alugados----------------");
            Console.WriteLine("-----------------Nome,Email----------------------");
            for (int i = 0; i < 10; i++)
            {
                //if (vect[i] != null)
                //{
                    Console.WriteLine("quarto: " + i + ":   " + vect[i]);// imprimi as informações
                //}
            }
        }
    }
}
