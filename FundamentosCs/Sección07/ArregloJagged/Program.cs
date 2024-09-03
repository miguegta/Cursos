/*
  Arreglos Jagged (Escalonados)
  tipo[][] nombre = new tipo[tamaño][]
 */

int[][] arregloJagged = new int[3][];
arregloJagged[0] = new int[] { 1, 2, 3 };
arregloJagged[1] = new[] { 4, 5 };
arregloJagged[2] = new[] { 6, 7, 8, 9 };

//Acceder
int valor = arregloJagged[1][0];
Console.WriteLine(valor);

//Modificar
arregloJagged [2][3] = 10;
Console.WriteLine(arregloJagged[2][3]);

foreach (int[] subarreglo in arregloJagged)
{
	foreach (int elemento in subarreglo)
	{
		Console.Write($"{elemento}\t");
	}
	Console.WriteLine();
}