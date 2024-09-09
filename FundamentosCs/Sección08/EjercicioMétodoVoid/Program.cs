Console.WriteLine("Ingresa el 1er número:");
double n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingresa el 2do número:");
double n2 = Convert.ToDouble(Console.ReadLine());

void CalcularSuma()
{
    double x = n1 + n2;
    Console.WriteLine($"La suma de {n1} + {n2} = {x}");
}

void CalcularResta()
{
    double x = n1 - n2;
    Console.WriteLine($"La resta de {n1} - {n2} = {x}");
}

void CalcularMultiplicacion()
{
    double z = n1 * n2;
    Console.WriteLine($"La multi de {n1} * {n2} = {z}");
} 

void CalcularDivision()
{
    double z = n1 / n2;
    Console.WriteLine($"La division de {n1} / {n2} = {z}");
}

CalcularSuma();
CalcularResta();
CalcularMultiplicacion();
CalcularDivision();


