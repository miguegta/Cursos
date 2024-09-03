string[,] notas =
{
    { "Juan",   "10",   "9",    "7" },
    { "Maria",  "10",   "10",   "5" },
    { "Pedro",  "9",    "9",    "2" },
    { "Alberto","10",   "10",   "8" }
};

int filas = notas.GetLength(0); //4
int columnas = notas.GetLength(1) -1;  //4
//Crear arreglo para los promedios
double[] promedios = new double[4];

Console.WriteLine("Notas de los estudiantes");
//Ciclo for
for (int i = 0; i < filas; i++)
{
    double suma = 0;
    for (int j = 1; j <= columnas; j++)
    {
        suma += Convert.ToInt32(notas[i, j]);
    }
    promedios[i] = suma / 3;
}

for (int i = 0; i < filas; i++)
{
    Console.Write($"{notas[i, 0]}\t");
    for (int j = 1; j <= columnas; j++)
    {
        Console.Write($"{notas[i,j]}\t");
    }
    Console.WriteLine($"{promedios[i]:0.##}");
   
}
