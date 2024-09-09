/*
  Diseñar un programa que simule un cajero automático. 
  El programa debe permitir al usuario realizar operaciones como consultar el saldo, depositar dinero y retirar dinero. 
  Además, el programa debe llevar un registro de las transacciones realizadas por el usuario. 
  Se debe implementar un método para cada tipo de operación.
 */

namespace EPropuesto03
{
    internal class Program
    {
        static void Main(string[] arg)
        {
            bool salir = false;
            decimal saldo = 0;

            while (salir == false)
            {
                Console.WriteLine("Que operación desea realizar?\n1. Consultar saldo\n2. Depositar\n3. Retirar\n4. Salir");
                int menu = Convert.ToInt32(Console.ReadLine());

                if (menu == 1)
                {
                    ConsultarSaldo();
                }
                else if (menu == 2)
                {
                    Depositar();
                }
                else if (menu == 3)
                {
                    Retirar();
                }
                else if (menu == 4)
                {
                    Console.WriteLine("Hasta luego!");
                    salir = true;
                }
                else
                {
                    Console.WriteLine("Ingresa una opción invalida\n");
                }
            }

            void ConsultarSaldo()
            {
                Console.WriteLine($"Su saldo actual es: {saldo:C}\n");

            }

            void Depositar()
            {
                Console.WriteLine("Cuánto desea depositar?");
                decimal deposito = Convert.ToDecimal(Console.ReadLine());
                saldo += deposito;
                Console.WriteLine($"Deposito exitoso! Se ha depositado: {deposito:C}");
                Console.WriteLine($"Su saldo actual es: {saldo:C}\n");
            }

            void Retirar()
            {
                Console.WriteLine("Cuánto desea retirar?");
                decimal retirar = Convert.ToDecimal(Console.ReadLine());
                if (saldo > retirar)
                {
                    saldo -= retirar;
                    Console.WriteLine($"Retiro exitoso! Se ha retirado: {retirar:C}");
                    Console.WriteLine($"Su saldo actual es: {saldo:C}\n");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente! No se ha podido realizar el retiro.");
                }
                Console.WriteLine($"Su saldo actual es: {saldo:C}\n");
            }
        }
    }
}
