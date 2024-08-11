/*
  Cree un programa que le permita al usuario ingresar las notas de sus materias
  y cuando ingrese la quinta y última nota, el programa debe mostrarle su
  promedio general.
 */

int notas = 0;
double sumaNotas = 0;
int index = 1;

Console.WriteLine("Ingresa la cantidad de notas: ");
notas = Convert.ToInt32(Console.ReadLine());

while (index <= notas)
{
    Console.WriteLine($"Ingresa la nota {index}:");
    double valor = Convert.ToInt32(Console.ReadLine());
    sumaNotas += valor;
    index++;
}

double promedio = sumaNotas / notas;
Console.WriteLine($"Tu promedio es: {promedio}");