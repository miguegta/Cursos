//Crear un for con incremento diferente.

for (int i = 0; i <= 50; i += 5) 
{
   // Console.WriteLine(i);
}

//Calcular la cantidad de días que toma gastar 100$.

int dinero = 100;
int dias = 0;

Console.WriteLine("¿Cuanto gastas diario?");
int consumo = Convert.ToInt32(Console.ReadLine());

for (int i = dinero; i > 0; i -= consumo)
{
    Console.WriteLine($"Dinero actual: {i}");
    dias++;
}

Console.WriteLine($"Según tu consum0 diario de {consumo:C}, vas a gastar {dinero:C} en {dias} días.");
