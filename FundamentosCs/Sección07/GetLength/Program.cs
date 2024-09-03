int[,] numeros = new int[4, 4]
{
    { 1,2,3,4 },
    { 5,6,7,8 },
    { 9,10,11,12 },
    { 13,14,15,16 }
};


//Metodo GetLength
int filas = numeros.GetLength(0);
int columnas = numeros.GetLength(0);

//Mostramos valores
Console.WriteLine($"N° de filas: {filas}"); // 4
Console.WriteLine($"N° de columnas: {columnas}\n"); //4
for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        //Console.Write($"[{i},{j}]\t");
        Console.Write($"{numeros[i,j]}\t");
    }
    Console.WriteLine();
}