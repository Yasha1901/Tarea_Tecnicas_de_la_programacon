using System;

namespace AreaPerimetroRectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular el área y perímetro de un rectángulo");

            double baseRectangulo = ObtenerDouble("Ingrese la base del rectángulo: ");
            double altura = ObtenerDouble("Ingrese la altura del rectángulo: ");

            Rectangulo rectangulo = new Rectangulo(baseRectangulo, altura);

            double area = rectangulo.CalcularArea();
            double perimetro = rectangulo.CalcularPerimetro();

            Console.WriteLine("El área del rectángulo es: " + area);
            Console.WriteLine("El perímetro del rectángulo es: " + perimetro);

            Console.ReadKey();
        }

        private static double ObtenerDouble(string mensaje)
        {
            Console.Write(mensaje);
            double valor;
            while (!double.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("Valor inválido. Intente nuevamente.");
                Console.Write(mensaje);
            }
            return valor;
        }

        private class Rectangulo
        {
            private double baseRectangulo;
            private double altura;

            public Rectangulo(double baseRectangulo, double altura)
            {
                this.baseRectangulo = baseRectangulo;
                this.altura = altura;
            }

            public double CalcularArea()
            {
                return baseRectangulo * altura;
            }

            public double CalcularPerimetro()
            {
                return 2 * (baseRectangulo + altura);
            }
        }
    }
}