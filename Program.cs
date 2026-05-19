// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a = 10;
// b = a;
// Console.WriteLine("valor de a:" + a);
// Console.WriteLine("valor de b:" + b);

//ejercicio 1
int numero;
Console.WriteLine("ingrese un número entero:");
if (int.TryParse(Console.ReadLine(), out numero))
{
    int aux;

    int numeroInvertido = 0;
    while (numero > 0)
    {
        aux = numero % 10;
        numeroInvertido = (numeroInvertido * 10) + aux;
        numero = numero / 10;
    }
    Console.WriteLine("El número invertido es: " + numeroInvertido);

}
else
{
    Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
}