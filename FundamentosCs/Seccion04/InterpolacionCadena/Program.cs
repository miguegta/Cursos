// 5 peras cuestan 100 quetzales.
int nPeras = 5;
decimal precio = 20;
decimal precioPera = nPeras * precio;
Console.WriteLine(nPeras + " peras cuestan " + precioPera + " dolares.");
Console.WriteLine("{0} peras cuestan {1} dolares", nPeras, precioPera);
Console.WriteLine($"{nPeras} peras cuestan {precioPera:C} dolares");
Console.WriteLine($"{nPeras} peras cuestan {MetodoQueRegresaUnPrecio():C} dolares.");

//Ejemplo con metodo
decimal MetodoQueRegresaUnPrecio()
{
    return nPeras * precio; // 100
}

//Como unir 2 string
string nombre = "Luis";
string apellido = "Solar";
Console.WriteLine(nombre + " " + apellido);
Console.WriteLine($"{nombre} {apellido}");

//
string autor = "Gianny Dantas";
string libro = "Programando en C#";
decimal precioLibro = 45m;
decimal precioCaro = 50M;
Console.WriteLine($"El libro \"{libro}\" es caro?\nRespuesta: {precioLibro >= precioCaro}");
