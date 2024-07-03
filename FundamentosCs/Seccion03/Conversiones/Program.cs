int numero = 12;
string numeroCadena = numero.ToString();
Console.WriteLine(numeroCadena);
bool booleando = true;
Console.WriteLine(booleando.ToString());

//Implicita
int n = 10;
double d = n;

//Explicita
double c = 9.8;
int i = (int) c;
Console.WriteLine(c);
Console.WriteLine(i);

//Clase Convert

int e = Convert.ToInt32(c); //Redondea el resultado, los pares los regresa
Console.WriteLine(e);       //Los impares hace los contrario

Console.WriteLine("------------------------------------");

//Metodo Parse
string edadTexto = "26";
int edad = int.Parse (edadTexto);
Console.WriteLine(edadTexto);
Console.WriteLine(edad);

//Uso de ReadLine
Console.WriteLine("Ingresa tu edad: ");
int miEdad = int.Parse(Console.ReadLine());
Console.WriteLine("Tu edad es " + miEdad);