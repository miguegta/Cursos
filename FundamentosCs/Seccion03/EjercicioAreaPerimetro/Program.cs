Console.WriteLine("Ingresa la base del triangulo");
double baseTriangulo = Convert.ToDouble(Console.ReadLine());
string alturaTexto = "10";
double alturaTriangulo = Convert.ToDouble(alturaTexto);

//Calcular Area
double area = (baseTriangulo * alturaTriangulo) / 2;
Console.WriteLine("El Area es: " + area);

var lado1 = 5.0;
var lado2 = 7.0;
var lado3 = 10.0;

//Hallar Perimetro
double perimetro = lado1 + lado2 + lado3;
Console.WriteLine("El perimetro del triangulo es: " + perimetro);

