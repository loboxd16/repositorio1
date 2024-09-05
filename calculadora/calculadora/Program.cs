// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese numero");

int numero1=int.Parse(Console.ReadLine());
int numero2=int.Parse(Console.ReadLine());
int resultado=numero1 + numero2;
Console.WriteLine($"El resultado es {resultado}");

Console.WriteLine("Ingrese numero limite while");
int numerolimite=int.Parse(Console.ReadLine());

int contador=0;
while (contador < numerolimite)
{
    contador=contador+1;
    Console.WriteLine(contador);


}

Console.WriteLine("Do-while");
contador = 0;
do
{
    contador = contador+1;
    Console.WriteLine(contador);
}while (contador < numerolimite);