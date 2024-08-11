/*
  Creamos un programa que nos permita adivinar un número aleatorio en x intentos
  además, indicar al usuario si el número introductorio es más bajo o alto que el 
  deseado.
 */

//int x = 15;
int intentos = 0;
int numero = 0;

Random rnd = new Random();
int x = rnd.Next(1, 51);

Console.WriteLine("Adivina un número del 1 al 50");

while (x != numero)
{
    intentos++;
    
    numero = Convert.ToInt32(Console.ReadLine());

    if (x > numero)
    {
        Console.WriteLine("El número es mayor");
    }
    else if (x < numero)
    {
        Console.WriteLine("El número es menor");
    }
}

Console.WriteLine($"CORRECTO, El numero deseade es: {x}");
Console.WriteLine($"Buen trabajo! fue logrado en {intentos} intentos.");