double[][] notas = new double[3][];
notas[0] = new[] { 9.5, 8.8, 7.2 };
notas[1] = new[] { 7.9, 8.1 };
notas[2] = new[] { 10, 8.9, 6.4, 2.4, 6.9 };

//Crear arreglos promedios (3)
double[] promedios = new double[notas.Length]; //3

for (int i = 0; i < notas.Length; i++)
{
    double suma = 0; //Resetea
    for (int j = 0; j < notas[i].Length; j++)
    {
        suma += notas[i][j];
    }
    promedios[i] = suma / notas[i].Length;
}

Console.WriteLine("promedios: ");
for (int i = 0; i < promedios.Length; i++)
{
    Console.WriteLine($"Estudiante {i + 1}: {promedios[i]:0.##}");
}