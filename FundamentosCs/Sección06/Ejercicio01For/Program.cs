//Calcular el promedio de notas de N cursos

int nCursos = 0;
double sumaNotas = 0;

Console.WriteLine("Ingresa la cantidad de cursos: ");
nCursos = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= nCursos; i++)
{
    Console.WriteLine($"Ingresa la nota n°{i}");
    double nota = Convert.ToDouble(Console.ReadLine());
    sumaNotas += nota;
}

double promedio = sumaNotas / nCursos;

Console.WriteLine($"La cantidad de cursos fue: {nCursos}");
Console.WriteLine($"El promedio es de: {promedio:0.###}");

