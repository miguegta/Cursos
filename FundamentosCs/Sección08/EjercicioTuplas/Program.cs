(string, int, string) ObtenerDatos()
{
    Console.WriteLine("Ingrese su nombre: ");
    string nombre = Console.ReadLine();

    Console.WriteLine("Ingrese su edad: ");
    int edad = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese su carrera: ");
    string carrera = Console.ReadLine();

    return (nombre, edad, carrera);
}

//Obtener datos
(string nombre, int edad, string carrera) estudiante = ObtenerDatos();

//Mostrar valores
Console.WriteLine($"El nombre del estudiante es: {estudiante.nombre}");
Console.WriteLine($"La edad del estudiante es: {estudiante.edad}");
Console.WriteLine($"La carrera del estudiante es: {estudiante.carrera}");