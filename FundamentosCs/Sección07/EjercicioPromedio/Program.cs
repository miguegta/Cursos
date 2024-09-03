//Calcular el promedio de gasto de una persona al comprar 3 productos.

double[,] gastos =
{
    { 95, 87, 91 },    //Persona 1  (0) 
    { 82, 79, 88 },    //Persona 2  (1)
    { 90, 24, 56 },    //Persona 3  (2)
    { 76, 82, 65 },    //Persona 4  (3)
    { 09, 42, 72 }     //Persona 5  (4)
};

//Obtener longitudes
int filas = gastos.GetLength(0); //5
int columnas = gastos.GetLength(1); //3
//Crear arreglo para los promedios
double[] promedios = new double[5];

//Ciclo for
for (int i = 0; i < filas; i++)
{
    double suma = 0;
    for (int j = 0; j < columnas; j++)
    {
        suma += gastos[i,j];
    }
    promedios[i] = suma / 3;
}

//Mostrar promedios
Console.WriteLine("promedio de los estudiantes");
for (int i = 0; i < promedios.Length; i++)
{
    Console.WriteLine($"Estudiante {i + 1}: {promedios[i]:0.##}");
}
