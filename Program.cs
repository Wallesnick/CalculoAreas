using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace CalculoArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double triangulo, circulo, trapezio, quadrado, retangulo;
            Console.WriteLine("Programa consiste em calcular a área de um TRIÂNGULO,CÍRCULO,TRAPÉZIO,QUADRADO,RETÂNGULO");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("Digite os valores separados somente por espaço: ");
            string[] valores = Console.ReadLine().Split(' ');
            double A = double.Parse(valores[0],CultureInfo.InvariantCulture);
            double B = double.Parse(valores[1],CultureInfo.InvariantCulture);
            double C = double.Parse(valores[2],CultureInfo.InvariantCulture);

            triangulo = (A * C) / 2;
            circulo = Math.Pow(C,2) * 3.14159;
            trapezio = (A+B) *  C / 2;
            quadrado = Math.Pow(B, 2);
            retangulo = A * B;
            //BASE(A) * ALTURA(C) / 2
            Console.WriteLine("TRIANGULO:{0} ",triangulo.ToString("F3",CultureInfo.InvariantCulture));
            //RAIO(B) AO QUADRADO * PI
            Console.WriteLine("CÍRCULO:{0} ", circulo.ToString("F3",CultureInfo.InvariantCulture));
            //BASES A E B * ALTURA(C)
            Console.WriteLine("TRAPÉZIO:{0} ", trapezio.ToString("F3",CultureInfo.InvariantCulture));
            //LADO(B) AO QUADRADO
            Console.WriteLine("QUADRADO:{0} ", quadrado.ToString("F3",CultureInfo.InvariantCulture));
            //LADO A * B
            Console.WriteLine("RETÂNGULO:{0} ", retangulo.ToString("F3",CultureInfo.InvariantCulture));








        }
    }
}
