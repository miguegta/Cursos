namespace EjercicioPropuesto07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = "";
            string password = "";

            string userLogin = "";
            string passwordLogin = "";

            Console.WriteLine("Crea una cuenta.\nIngresa tu nuevo usuario.");
            userLogin = Console.ReadLine();

            Console.WriteLine("Ingresa tu nueva contraseña.");
            passwordLogin = Console.ReadLine();

            Console.WriteLine("Perfecto has creado tu cuenta satisfactoriamente!");

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Inicio de sesion Ingresa tu usuario\nUsuario:");
                user = Console.ReadLine();

                Console.WriteLine("Password:");
                password = Console.ReadLine();

                if (user == userLogin && password == passwordLogin)
                {
                    Console.WriteLine("\nBienvenido! has iniciado sesion correctamente.");
                    i = 4;
                }
                else if (i >= 3)
                {
                    Console.WriteLine("\nERROR! intenta más tarde.\n");
                }
                else 
                {
                    Console.WriteLine("Tu usuario y contraseña no son correctos, Intenta de nuevo.\n");
                }
            }









        }
    }
}
