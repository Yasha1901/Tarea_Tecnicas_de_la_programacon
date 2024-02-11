using System;

namespace AreaPerimetroRectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            double area, perimetro, baseRectangulo, altura;

            // Pedir valores al usuario
            Console.WriteLine("Ingrese la base del rectángulo: ");
            baseRectangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del rectángulo: ");
            altura = Convert.ToDouble(Console.ReadLine());

            // Calcular área y perímetro
            area = baseRectangulo * altura;
            perimetro = 2 * (baseRectangulo + altura);

            // Mostrar resultados
            Console.WriteLine("El área del rectángulo es: " + area);
            Console.WriteLine("El perímetro del rectángulo es: " + perimetro);

            Console.ReadKey();
        }
    }
}