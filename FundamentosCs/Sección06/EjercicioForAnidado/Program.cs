/*
 * Hacer uso de for anidado y dibujar:
 *              ***** (5)
 *              **** (4)
 *              *** (3)
 *              ** (2)
 *              * (1)
 */

int altura = 10;

for (int i = altura; i >= 1; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}