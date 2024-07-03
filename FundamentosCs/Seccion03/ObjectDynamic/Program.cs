// ** OBJECT **
object altura = 1.70;
object nombre = "pedro";
//int lo2 nombre.Length; <---- No se puede
int lo3 = ((string)nombre).Length;
Console.WriteLine(nombre + " tiene " + altura + " metros de alto.");

//Uso de Length 
string apellido = "Rosas";
int lo = apellido.Length;
Console.WriteLine(lo);
Console.WriteLine(apellido + " tiene " + lo + " caracteres.");

// ** DYNAMIC **
dynamic algo = "Carrera";
Console.WriteLine(algo.Length);