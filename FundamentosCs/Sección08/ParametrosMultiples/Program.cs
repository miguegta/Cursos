void MostrarElementos(params int[] numeros)
{
    for (int i = 0; i < numeros.Length; i++)
    {
        Console.WriteLine(numeros[i]);
    }
}

int[] n = { 1, 2, 3, 4, 5, 6 };

MostrarElementos(n);
MostrarElementos(6, 7, 8, 9);
