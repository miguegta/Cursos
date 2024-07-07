//Crear variables
double nota1 = 0;
double nota2 = 0;
double nota3 = 0;
double promedio = 0;

//Obtener datos
Console.WriteLine("Dame la 1ra nota");
nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Dame la 2da nota");
nota2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Dame la 3ra nota");
nota3 = Convert.ToDouble(Console.ReadLine());

//Calcular promedio
promedio = (nota1 + nota2 + nota3) / 3;
Console.WriteLine($"El promedio de las 3 notas es de: {promedio}");