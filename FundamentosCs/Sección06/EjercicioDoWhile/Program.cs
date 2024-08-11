/*
  El programa solicita al usuario que ingrese un número positivo.
  Si el número ingresado es positivo, se muestra en pantalla.
  Si el número ingresado es negativo, se muestra un 
  mensaje de error y se le pide al usuario que
  ingrese nuevamente un número positivo.
 */

int numero = 0;

do
{
    Console.WriteLine("Ingresa un número positivo.\nPresione 0 para salir del programa.");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero > 0)
    {
        Console.WriteLine($"El número ingresado es: {numero}");
        Console.WriteLine("-------------------------------");
    }

    else if (numero < 0)
    {
        Console.WriteLine($"El número ingresado es negativio es: {numero}, intentalo otra vez.");
        Console.WriteLine("-------------------------------");
    }

}
while (numero != 0) ;

Console.WriteLine("Fin del programa, hasta luego!");
