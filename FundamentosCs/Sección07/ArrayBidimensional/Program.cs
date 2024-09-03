//Declarar e inicializar valores
int[,] array = new int[4, 4];

//Asignar valores

//Primera fila
array[0, 0] = 12;
array[0, 1] = 14;
array[0, 2] = 16;
array[0, 3] = 18;

//Segunda fila
array[1, 0] = 21;
array[1, 1] = 23;
array[1, 2] = 25;
array[1, 3] = 27;

//Tercera fila
array[2, 0] = 30;
array[2, 1] = 32;
array[2, 2] = 36;
array[2, 3] = 39;

//Cuarta fila
array[3, 0] = 41;
array[3, 1] = 43;
array[3, 2] = 45;
array[3, 3] = 48;

//Mostrar valores
Console.WriteLine($"Valor que se encuentra en (1,3): {array[1, 3]}");
Console.WriteLine($"Valor que se encuentra en (2,2): {array[2, 2]}");
