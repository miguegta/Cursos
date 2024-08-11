namespace EjercicioPropuesto08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuesta = "";
            int i = 0;
            int j = 0;

            Random rnd = new Random();
            string[] opciones = { "piedra", "papel", "tijera" };
            int x = rnd.Next(0, opciones.Length);
            string eleccionAleatoria = opciones[x];



            while (respuesta != eleccionAleatoria || respuesta == eleccionAleatoria)
            {
                Console.WriteLine("Escribe tu opción:\npiedra\npapel\ntijera\n");
                respuesta = Console.ReadLine();

                if (Array.Exists(opciones, opcion => opcion == respuesta))
                {

                    if ((respuesta == "piedra" && eleccionAleatoria == "tijera") ||
                        (respuesta == "papel" && eleccionAleatoria == "piedra") ||
                        (respuesta == "tijera" && eleccionAleatoria == "papel"))
                    {
                        Console.WriteLine(eleccionAleatoria);
                        Console.WriteLine("\nGood job!\n");
                        i++;
                    }
                    if (i >= 3)
                    {
                        Console.WriteLine("\nHas ganado el juego!\n");
                    }
                    if (j >= 3)
                    {
                        Console.WriteLine("\nHas perdido el juego vuelve a intentarlo!\n");
                    }
                    else if (respuesta == eleccionAleatoria)
                    {
                        Console.WriteLine(eleccionAleatoria);
                        Console.WriteLine("\nEmpate vuelve a jugar.\n");
                    }
                    else
                    {
                        Console.WriteLine(eleccionAleatoria);
                        Console.WriteLine("\nOoohh Vamos tu puedes hacerlo!.\n");
                        j++;
                    }
                }
                else
                {
                    Console.WriteLine("\nEntrada no válida. Por favor, ingresa 'piedra', 'papel' o 'tijera'.\n");
                }
            }
        }
    }
}
