// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Ingresa un limite");
int contador = 0;
int limite=int.Parse(Console.ReadLine());
while (contador < limite)
{
    contador++;
    Console.WriteLine(contador);

}
contador = 0;
Console.WriteLine("..................");

for (int i = 0; i < limite; i++)
{
    Console.WriteLine(i);
}
*/
Console.WriteLine("ingresa numero de la tabla");

int numerotabla=int.Parse(Console.ReadLine());

Console.WriteLine("...........");

for (int i = 1; i <= 12; i++){ 
    int resultado = numerotabla * i;
Console.WriteLine($"{numerotabla}*{i}={resultado}");

}