double numeroEntero = 0;
double sumaNumerosPares = 0;
double sumaNumerosImpares = 0;

Console.WriteLine("Ingresa un número entero");
numeroEntero = Convert.ToDouble(Console.ReadLine());

Console.Write($"números pares: ");

for (int i = 1; i <= numeroEntero; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
        sumaNumerosPares += i;
    }
}

Console.WriteLine();
Console.Write($"números impares: ");

for (int i = 1; i <= numeroEntero; i++)
{
    if (i % 2 != 0)
    {
        Console.Write($"{i} ");
        sumaNumerosImpares += i;
    }
}

Console.WriteLine("\n");
Console.WriteLine($"La suma de los números pares es: {sumaNumerosPares}");
Console.WriteLine($"La suma de los números impares es: {sumaNumerosImpares}");