//Ejemplo 1

int edad = 14;

if (edad >= 18)
{
    Console.WriteLine("Soy mayor de edad.");
}
else
{
    Console.WriteLine("Faltan 4 años para los 18.");
}

//Ejemplo 2

int numero;
Console.WriteLine("Ingresa un numero entero: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
    // N es par
    Console.WriteLine($"El número {numero} es par.");
}
else
{
    // N es impar
    Console.WriteLine($"El numero {numero} es impar.");
}