/*
  Buscar el valor máximo y mínimo en el arreglo.
  Mostrar resultados.
 */

int[] numeros = { 5, 10, 3, 8, 15, 20 };

//Mostrar arreglo
void MostrarArray(int[] array)
{
    Console.WriteLine("Array:");
    foreach (int n in array)
    {
        Console.Write($"{n} ");
    }
    Console.WriteLine();
}

MostrarArray(numeros);

//Método para buscar maximos y minimos
void EncontrarMaximoMinimo(int[] miArreglo)
{
    int max = miArreglo[0]; //5
    int min = miArreglo[0]; //5

    for (int i = 1; i < miArreglo.Length; i++)
    {
        if (miArreglo[i] > max)
        {
            max = miArreglo[i]; //20
        }

        //Valor minimo
        if (miArreglo[i] < min)
        {
            min = miArreglo[i]; //3
        }
    }

    Console.WriteLine($"Maximo: {max}");
    Console.WriteLine($"Minimo: {min}");

}

EncontrarMaximoMinimo(numeros);