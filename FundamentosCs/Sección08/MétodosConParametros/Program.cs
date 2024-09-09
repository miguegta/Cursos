/*
 void NombreMetodo(tipo1 nombre, tipo2 nombre, ... 
{
    Cuerpo del método
}
*/

void MostrarInfo(string nombre, int edad, double altura)
{
    Console.WriteLine($"El nombre del paciente es: {nombre}");
    Console.WriteLine($"La edad del paciente es: {edad}");
    Console.WriteLine($"La altura del paciente es: {altura} m.");
}

MostrarInfo("Jose", 20, 1.70);
MostrarInfo("Maria", 25, 1.65);
MostrarInfo("Paco", 32, 1.82);




