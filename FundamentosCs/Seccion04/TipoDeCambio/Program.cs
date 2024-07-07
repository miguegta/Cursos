//Crear variables
double tasaCompraDolares = 0;
double tasaVentaDolares = 0;

//Obtener tasas
Console.WriteLine("Ingresa la tasa de cambio para comprar dolares: ");
tasaCompraDolares =  Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingresa la tasa de cambio para vender dolares: ");
tasaVentaDolares = Convert.ToDouble(Console.ReadLine());

//Comprar dolares (Cambiar de Quetzales a Dolares)
Console.WriteLine("Ingreas cuantos dolares quieres comprar: ");
double nDolares = Convert.ToDouble(Console.ReadLine());
double cambioCompraDolares = nDolares * tasaVentaDolares;
Console.WriteLine($"Comprarnos {nDolares} dolares equivale depositarnos {cambioCompraDolares} Quetzales.");

//Verder dolares (Cambiar Dolares a Quetzales)
Console.WriteLine("Ingresa cuantos dolares quieres vender: ");
double numDolares = Convert.ToDouble(Console.ReadLine());
double cambioVentaDolares = numDolares * tasaCompraDolares;
Console.WriteLine($"Vendernos {numDolares} dolares equivale darte {cambioVentaDolares} Quetzales.");