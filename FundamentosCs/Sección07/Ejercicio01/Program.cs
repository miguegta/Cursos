//Programa que busca el número mayor y menor en un array.

int[] numeros = new int[10];
int nMenor = 0;
int nMayor = 0;
int index = 0;
    
while (index < 10)
{
    Console.WriteLine($"Ingresa el número {index + 1}:");
    numeros[index] = Convert.ToInt32(Console.ReadLine());
    index++;
}

for (int i = 0; i < numeros.Length; i++)
{
    //Asignar el 1er valor del arreglo a nuestras variables
    if (i == 0)
    {
        nMenor = numeros[0];
        nMayor = numeros[0];
    }

    //Ahora realizaremos las comparaciones
    if (numeros[i] < nMenor)
    {
        nMenor = numeros[i];
    }
    if (numeros[i] > nMayor)
    {
        nMayor = numeros[i];
    }
}

//Mostrar los resultados
Console.WriteLine($"\nEl número menor es: {nMenor}");
Console.WriteLine($"El número mayor es: {nMayor}\n");