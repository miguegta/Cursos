//Ejemplo
const int RUEDAS = 4;
const int PUERTAS = 6;

int autos = 5;

//Totales
int totalRuedas = autos * 4; //20
int totalPuertas = autos * PUERTAS; //30
Console.WriteLine("El total de ruedas es : " + totalRuedas);
Console.WriteLine("El total de puertas es : " + totalPuertas);

// Ejercicio 01 : Hallar area de un circulo 
const double PI = 3.1416;
string radioTexto = "5";

double radio = double.Parse(radioTexto);
double area = radio * radio * PI;
Console.WriteLine("El area del circulo es : " + area);

//Usando clase Math
double area2 = radio * radio * Math.PI;
Console.WriteLine("El area del circulo es : " + area2);

//Ejemplo 02 con clase Math
double area3 = Math.Pow(radio, 2) * Math.PI;
Console.WriteLine("El area del circulo es : " + area3);
