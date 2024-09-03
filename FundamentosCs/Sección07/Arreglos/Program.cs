//int[] edades = new int[5];

int[] edades;
edades = new int[5];

//Asignar valores
edades[0] = 24;
edades[1] = 10;
edades[2] = 23;
edades[3] = 30;
edades[4] = 15;

//Mostrar valores
Console.WriteLine($"El index 0: {edades[0]}");
Console.WriteLine($"El index 1: {edades[1]}");
Console.WriteLine($"El index 2: {edades[2]}");
Console.WriteLine($"El index 3: {edades[3]}");
Console.WriteLine($"El index 4: {edades[4]}");

Console.WriteLine("------------------------------");

//Crear arreglo directamente
//string[] nombres = new string[4]; Declarar y luego asignar
string[] nombres = new[] { "Pedro", "Martín", "Maria", "Miguel" };

//Mostrar 1er nombre
//int l = nombres.Length;   Obtener total de elementos
string n = nombres[nombres.Length - 1];
Console.WriteLine($"El último nombre es: {n}");

