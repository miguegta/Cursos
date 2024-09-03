using System.Collections;

int[] numeros = { 5, 2, 6, 10, 9, 11, 15, 20 };

//Busqueda sencilla
int numeroDeseado = 20;
bool encontrado = false;
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == numeroDeseado)
    {
        encontrado = true;
    }
}
if (encontrado)
{
    Console.WriteLine($"Número encontrado: {numeroDeseado}");
}

//Usando el método Array.IndexOf()

int index = Array.IndexOf(numeros, 50);

if (index != -1) //Index == -1 
{
    Console.WriteLine($"El número 50 se encuentra en el index: {index}");
}
else
{
    Console.WriteLine("El número no se encuentra en el arreglo números.");
}

//Usando Array.Find y función lambda.
int x  = Array.Find(numeros, k => k > 7);
if (x != 0)
{
    Console.WriteLine($"El 1er número mayor a 7 es: {x}");
}
else
{
    Console.WriteLine("El número mayor no encontrado");
}

//Usando LINQ (FirsOrDefault())
int num = numeros.FirstOrDefault(m => m == 15);
if (num != 0)
{
    Console.WriteLine($"El número 15 si existe.");
}
else
{
    Console.WriteLine("El número 15 no existe.");
}