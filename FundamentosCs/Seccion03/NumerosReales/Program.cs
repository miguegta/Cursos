//Entre 6-9 digitos de precisión
float a = 1;

//Entre 15-17 digitos de presición
double b = 2;

//Entre 28-29 digitos de presición
decimal c = 3;

//Sufijo
double d = 3d;
d = 4d;
d = 3.934_001;

float f = 3_000.5f;
f = 5.4f;

decimal dinero = 3_000.5m;
dinero = 400.75M;

Console.WriteLine("---------------------");

//Comparar Double y Decimal
Console.WriteLine("Usuando double");
double v1 = 0.1;    //No es recomendable utilizar variables tipo doubles para comparar
double v2 = 0.2;    /*Solo se usa para comparar si es mayor que o menor que 
                      O resultados que no sean exactos*/
if (v1 + v2 == 0.3)
{
    Console.WriteLine("Es verdadero.");
}
else
{
    Console.WriteLine("No es verdadero.");
}

//Decimal
Console.WriteLine("Usando decimal");
decimal d1 = 0.1m;
decimal d2 = 0.2m;

if (d1 + d2 == 0.3m)
{
    Console.WriteLine("Es verdadero.");
}
else
{
    Console.WriteLine("No es verdadero");
}

