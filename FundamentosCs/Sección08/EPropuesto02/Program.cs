/*
  Diseñar un programa en C# que calcule el impuesto a pagar por un trabajador con base en su salario anual. 
  El programa debe solicitar al usuario ingresar el salario anual y mostrar el monto de impuestos a pagar. 
  El impuesto se calcula según las siguientes reglas:
  * Si el salario anual es menor o igual a $50,000, el impuesto es el 10% del salario.
  * Si el salario anual es mayor a $50,000, pero menor o igual a $100,000, el impuesto es el 15% del salario.
  * Si el salario anual es mayor a $100,000, el impuesto es el 20% del salario. 
  Se debe implementar un método para calcular el impuesto basándonos en el salario ingresado.
 */


using System.Numerics;

namespace EPropuesto02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa su salario anual.");
            double salarioAnual = Convert.ToDouble(Console.ReadLine());

            double totalImpuestos;

            double CalcularImpuesto(double salarioAnual)
            {
                if (salarioAnual <= 50_000)
                {
                    totalImpuestos = salarioAnual * 0.10;
                }
                else if (salarioAnual > 50_000)
                {
                    totalImpuestos = salarioAnual * 0.15;
                }
                else
                {
                    totalImpuestos = salarioAnual * 0.20;
                }

                return totalImpuestos;
            }

            double totalImpuesto = CalcularImpuesto(salarioAnual);

            Console.WriteLine($"El salario Anual es: {salarioAnual:C}");
            Console.WriteLine($"El impuesto a pagar es : {totalImpuesto:C}");
        }
    }
}
