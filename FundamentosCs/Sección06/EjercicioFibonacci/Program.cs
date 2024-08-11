/*
  Fibonacci:
  Es una serie que empieza por 0 y 1, y el siguiente número
  es la suma de los dos anteriores, ejemplo:
  0,1,1,2,3,5,8,13,21,34,55,89,144,233,377,610,987,1597...
 */

int primerValor = 0;
int segundoValor = 1;
int suma = 0;

Console.WriteLine("¿Cuántos números de la serie Fibonacci desea ver: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Serie Fibonacci: ");

for (int i = 0; i < n; i++)
{
    suma = primerValor + segundoValor;
    Console.Write($"{suma} ");

    primerValor = segundoValor;
    segundoValor = suma;


}