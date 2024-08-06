//Programa permite ingresar un número entero y regresa cuantas cifras tiene.

Console.WriteLine($"Ingresa un número positivo: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero < 10)
{
    Console.WriteLine($"El número tiene un dígito.");
}
else
{
    if (numero < 100)
    {
        Console.WriteLine($"El número tiene 2 dígitos.");
    }
    else
    {
        if (numero < 1000)
        {
            Console.WriteLine($"El número tiene 3 dígitos.");
        }
        else
        {
            Console.WriteLine($"El número tiene más de 3 dígitos");
        }
    }
}

