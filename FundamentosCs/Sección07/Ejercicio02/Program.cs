/*El programa solicita al usuario información sobre 5 estudiantes,
  info sobre sus nombres, edades y promedios.
  Luego, se muestra la información de los estudiantes 
  y se calcula el promedio general.
  Además mostrar el nombre del estudiante con mayor promedio.
 */

string[] nombres = new string[5];
int[] edades = new int[5];
double[] promedios = new double[5];

//Solicitar info
for (int i = 0; i < 5; i++ )
{
    Console.WriteLine($"Ingrese los datos del estudiante {i + 1}");
    Console.WriteLine("Nombre : ");
    nombres[i] = Console.ReadLine();

    Console.WriteLine("Edad : ");
    edades[i] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Promedio : ");
    promedios[i] = Convert.ToDouble(Console.ReadLine());

}

Console.WriteLine("\n");

//Mostrar info de cadad estudiante
Console.WriteLine("Info estudiantes: ");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Estudiante {i + 1}: 1");
    Console.WriteLine($"Nombre: {nombres[i]}");
    Console.WriteLine($"Edad: {edades[i]}");
    Console.WriteLine($"Promedio: {promedios[i]}");
}

//Calcular promedio general
Console.WriteLine("Promedio general");
double promGeneral = 0;
for (int i = 0; i < 5; i++)
{
    promGeneral += promedios[i]; 
}

promGeneral /= 5;
Console.WriteLine($"El promedio general es {promGeneral:0.##}");

//Buscar promedio más alto.
double maxPromedio = promedios[0];
string nombreEstu = "";
for (int i = 0; i < 5; i++)
{
    if (promedios[i] > maxPromedio)
    {
        maxPromedio = promedios[i];
        nombreEstu = nombres[i];
    }
}

Console.WriteLine($"El estudiante con el promedio más alto: {nombreEstu}");


