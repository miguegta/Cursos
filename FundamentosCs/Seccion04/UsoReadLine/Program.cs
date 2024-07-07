//Uso de ReadLine
WriteLine("Introduce tu nombre: ");
string? nombre = ReadLine();
WriteLine($"El nombre que ingresaste es {nombre}");

//Leer numero
WriteLine("Introduce tu edad: ");
string? edadTexto = ReadLine();
int edad = Convert.ToInt32(edadTexto);
WriteLine($"Mi edad es {edad}");

//Posible error
WriteLine("Introduce tu telefono");
string? tel = ReadLine();
WriteLine($"Mi telefono es {tel}");