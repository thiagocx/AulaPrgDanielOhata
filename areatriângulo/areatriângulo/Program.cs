using ladotriângulo;
using System;
using System.Globalization;

namespace areatriângulo
{
    class Program
    {

        static void Main(string[] args)
        {
            trianguloX x;
            x = new trianguloX();

            trianguloY y;
            y = new trianguloY();
            
            Console.WriteLine("Entre com as medidas do triangulo x: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.D = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triangulo y: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.D = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            double areay = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));
            Console.WriteLine("O valor de Y é :" + areay.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor de x é :" + areaX.ToString("F4", CultureInfo.InvariantCulture));

            if (areay > areaX)
            {
                Console.WriteLine("O triângulo Y é o maior");
            }
            else
            {
                Console.WriteLine("Triângulo X é o maior");
            }

        }

    }
}