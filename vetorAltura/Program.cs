using System;
using System.Globalization;

namespace vetorAltura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n° de pessoas: ");
            //Criando a variável de entrada
            int n = int.Parse(Console.ReadLine());
            //Criando vetor com o número da variável de entrada
            double[] vect = new double[n];
            //Utilização do comando for para percorrer o vetor
            for (int i = 0; i < n; i++)
            {
                //Entrada dos elementos no vetor pelo usuário
                Console.WriteLine("altura da pessoa " + i +":");
                vect[i] = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);
            }
            //Variável soma
            double sum = 0.0;
            //Utilização do for para percorrer o vetor
            for (int i = 0; i < n; i++)
            {
                //Somatoria dos elementos inseridos
                sum += vect[i];
            }
            double media = sum / n;
            Console.WriteLine("O valor da média das alturas informadas é: " +  media);
        }
    }
}
