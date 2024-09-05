// See https://aka.ms/new-console-template for more information

int opcion = 0;
while (opcion != 7) { 
Console.WriteLine("Ingresa los numeros a operar");
int numero1=int.Parse(Console.ReadLine());
int numero2=int.Parse(Console.ReadLine());
int resultado = 0;

Console.WriteLine("1 sumar");
Console.WriteLine("1 restar");
Console.WriteLine("1 multiplicar");
Console.WriteLine("1 dividir");
Console.WriteLine("1 potencia");
Console.WriteLine("1 raiz");
Console.WriteLine("1 salir");
Console.WriteLine("ingresa opcion");
opcion=int.Parse(Console.ReadLine());
switch (opcion)
{
    case1:
    resultado = numero2 + numero1;
    break;
case 2:
resultado = numero2 + numero1;
        break;
    case 2:
resultado = numero2 + numero1;
        break;
    case 3:
resultado = numero2 + numero1;
        break;
    case 4:
resultado = numero2 + numero1;
        break;
    default:
break;
    
}
Console.WriteLine("resultado es{Math.Round(resultado, 2)";
    }
    Console.WriteLine("Salida");