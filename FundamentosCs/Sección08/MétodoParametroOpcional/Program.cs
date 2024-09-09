void Prueba(int edad = 20)
{

}

Prueba();

//Ejercicio
void Saludar(string nombre, string saludo = "Hola")
{
    Console.WriteLine ($"{saludo}, {nombre}");
}

//Llamar método sin usar argumento definido
Saludar("Maria");   //Hola, Maria

//Llamar método y modificar argumento definido
Saludar("Pedro", "Buenas noches");