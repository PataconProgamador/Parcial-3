
using Problema_1_Clase_abstracta;

namespace Problema_1_Clase_abstracta
{
    using System;

    namespace Problema_1_Clase_abstracta
    {
        // La clase abstracta 
        public abstract class Figura
        {
            public abstract double CalcularArea();
            public abstract double CalcularPerimetro();
        }

        // Clase derivada: Rectangulo
        public class Rectangulo : Figura
        {
            public double Base { get; set; }
            public double Altura { get; set; }

            public Rectangulo(double @base, double altura)
            {
                Base = @base;
                Altura = altura;
            }

            public override double CalcularArea() => Base * Altura;
            public override double CalcularPerimetro() => 2 * (Base + Altura);
        }

        // Clase derivada: Cuadrado
        public class Cuadrado : Figura
        {
            public double Lado { get; set; }

            public Cuadrado(double lado)
            {
                Lado = lado;
            }

            public override double CalcularArea() => Lado * Lado;
            public override double CalcularPerimetro() => 4 * Lado;
        }

        // Clase derivada: Triangulo
        public class Triangulo : Figura
        {
            public double Base { get; set; }
            public double Altura { get; set; }
            public double LadoA { get; set; }
            public double LadoB { get; set; }
            public double LadoC { get; set; }

            public Triangulo(double @base, double altura, double ladoA, double ladoB, double ladoC)
            {
                Base = @base;
                Altura = altura;
                LadoA = ladoA;
                LadoB = ladoB;
                LadoC = ladoC;
            }

            public override double CalcularArea() => (Base * Altura) / 2.0;
            public override double CalcularPerimetro() => LadoA + LadoB + LadoC;
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Arreglo unidimensional de tipo padre 
                Figura[] figuras = new Figura[]
                {
                new Rectangulo(5.0, 3.0),
                new Cuadrado(4.0),
                new Triangulo(6.0, 4.0, 5.0, 5.0, 6.0)
                };

                Console.WriteLine("--- RECORRIDO DE FIGURAS GEOMÉTRICAS ---\n");

                //Recorrido polimórfico
                foreach (Figura fig in figuras)
                {
                    string nombreClase = fig.GetType().Name;
                    double area = fig.CalcularArea();
                    double perimetro = fig.CalcularPerimetro();

                    Console.WriteLine($"Clase: {nombreClase}");
                    Console.WriteLine($"  - Áreas: {area:F2}");
                    Console.WriteLine($"  - Perímetro: {perimetro:F2}");
                    Console.WriteLine(new string('-', 30));
                }
            }
        }
    }
}
