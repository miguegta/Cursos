//Ejercicio 1
Console.WriteLine("Ejercicio 1");

string baseTexto = "5";
string alturaTexto = "8";

double baseDouble = Convert.ToDouble(baseTexto);
double alturaDouble = Convert.ToDouble(alturaTexto);

double totalBase = baseDouble * 2;
double totalAltura = alturaDouble * 2;

Console.WriteLine("El Perimetro es: " + (totalBase + totalAltura));
Console.WriteLine("");

//Ejercicio 2
Console.WriteLine("Ejercicio 2");

Console.WriteLine("Ingrese Primera nota: ");
int nota1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese Segunda nota: ");
int nota2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese Tercera nota: ");
int nota3 = Convert.ToInt32(Console.ReadLine());

int sumaNotas = nota1 + nota2 + nota3;
int notaFinal = sumaNotas / 3;

Console.WriteLine("El Promedio final es: " + notaFinal);
Console.WriteLine("");

//Ejecicio 3
Console.WriteLine("Ejercicio 3");

decimal agua = 90.00m;
decimal luz = 65.00m;
decimal cable = 45.00m;
decimal internet = 90.00m;
decimal telefono = 45.00m;
decimal sumaCosto = agua + luz + cable + internet + telefono;

Console.WriteLine("El costo total es: {0} dolares.", sumaCosto);
