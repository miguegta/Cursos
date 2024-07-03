// Número >= 0
uint numeroNatural = 23;

// N Positivo o Negativo
int numero = -30;

// Declarando
int n;
n = 10; // Asignar

// Declarar e inicializar
int n2 = 20;
n2 = 30; //Asignando un nuevo valor

// Almacenar números reales
float numerReal = 2.5F;
decimal numeroReal2 = 3.0M;
double numeroReal3 = 4.5;

// Mostrar el tipo
var num = 9.6M;
Console.WriteLine(num.GetType());

//****************************************

int edadJuan = 25;
int edadPedro = 20;
int sumaEdades = edadJuan + edadPedro;      //45 
int restaEdades = edadJuan - edadPedro;     // 5
int divEdades = edadJuan / edadPedro;       // 1
int multiEdades = edadJuan * edadPedro;     // 500
int moduloEdades = edadJuan % edadPedro;    // 5
Console.WriteLine(sumaEdades);
Console.WriteLine(restaEdades);
Console.WriteLine(divEdades);
Console.WriteLine(multiEdades);
Console.WriteLine(moduloEdades);

Console.WriteLine("-----------------------------");

Console.WriteLine(25 + 20);
Console.WriteLine(edadJuan + edadPedro);
Console.WriteLine(edadJuan % edadPedro);

Console.WriteLine("------------------------------");

int n5 = 50;
Console.WriteLine(n5);
n5 = 90;
Console.WriteLine(n5);

Console.WriteLine("-------------------------------");

int dosMillones = 2000000;
int notacionDecimal = 2_000_000;
int notacionBinaria = 0b_0001_1110_1000_0100_1000_0000;
int notacionHexadecimal = 0x_001E_8480;

Console.WriteLine(dosMillones);
Console.WriteLine(notacionDecimal);
Console.WriteLine(notacionBinaria);
Console.WriteLine(notacionHexadecimal);

Console.WriteLine(notacionDecimal == notacionBinaria); // Comparar variables
