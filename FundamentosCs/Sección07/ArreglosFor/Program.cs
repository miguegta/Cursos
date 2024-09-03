//Programa para ingresar notas y luego mostrarlas con el promedio total.

Console.WriteLine("¿Cuántas notas desea guardar?");
int n = Convert.ToInt32(Console.ReadLine());

//Crear Array
double[] notas = new double[n];
double suma = 0;

//Llenar el array
for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"Ingresa la nota {i + 1}: ");
    notas[i] = Convert.ToDouble(Console.ReadLine());
    suma += notas[i];
}

//Mostrar notas
for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"La nota ingresada fue: {notas[i]} ");
}


//Mostrar promedio 
double promedioFinal = suma / n;
Console.WriteLine($"\nEl promedio es: {promedioFinal}");