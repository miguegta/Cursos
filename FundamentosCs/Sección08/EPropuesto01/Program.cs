/*
  Diseñar un programa en C# que calcule el área de un triángulo dados su base y altura. 
  El programa debe solicitar al usuario que ingrese los valores de la base y la altura, 
  y luego mostrar el resultado del cálculo del área en pantalla.
 */

Console.WriteLine("Ingresa la base del triangulo.");
double baseTriangulo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa la altura del triangulo.");
double alturaTriangulo = Convert.ToInt32(Console.ReadLine());

void CalcularArea()
{
    double area = 0.5 * (baseTriangulo * alturaTriangulo);
    Console.WriteLine($"El área del tringulo es: {area} Unidades cuadradas");
}

CalcularArea();