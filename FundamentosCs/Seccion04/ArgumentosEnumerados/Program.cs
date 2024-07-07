//Uso de argumentos enumerados

string nombre = "Luis";
int numeroHermanos = 2;
Console.WriteLine(nombre + " tiene " + numeroHermanos + " hermanos.");
Console.WriteLine("{0} tiene {1} hemanos.", nombre, numeroHermanos);

//Podemos hacer operaciones 
int nManzanas = 5;
decimal precio = 10M;
Console.WriteLine(format: "{0} manzanas cuestan {1} quetzales.", nManzanas, nManzanas * precio);
Console.WriteLine(format: "{0} manzanas cuestan {1:C} quetzales.", nManzanas, nManzanas * precio);

//Uso de argumento enumerado (arg)
string nombre2 = "Roger";
string apellido = "Moreno";
string ciudad = "Lima";
Console.WriteLine(format: "{0} {1} vive en {2}", arg0: nombre2, arg1: apellido, arg2: ciudad);

//Uso de varios argumentos
Console.WriteLine(format: "Mis cosas favoritas son {0} {1} {2} {3} {4}", "celular", "PC",
    "Consola", "Pulsera", "Teclado");

//Se puede usar metodos dentro de WriteLine
int MetodoQueRegresaMiEdad()
{
    return 26;
}
Console.WriteLine("Yo tengo {0} años.", MetodoQueRegresaMiEdad());

