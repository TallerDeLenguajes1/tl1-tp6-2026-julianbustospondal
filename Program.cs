// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a = 10;
// b = a;
// Console.WriteLine("valor de a:" + a);
// Console.WriteLine("valor de b:" + b);

// ejercicio 1
int numero;
Console.WriteLine("ingrese un número entero mayor que 0:");
if (int.TryParse(Console.ReadLine(), out numero) && numero > 0)
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

// ejercicio 2
Console.WriteLine("Ingrese un número entero:");
if (int.TryParse(Console.ReadLine(), out numero))
{
    Console.WriteLine("El valor absoluto del numero ingresado es: " + Math.Abs(numero));
    Console.WriteLine("El cuadrado del numero ingresado es: " + Math.Pow(numero, 2));
    Console.WriteLine("La raiz cuadrada del numero ingresado es: " + Math.Sqrt(numero));
    Console.WriteLine("El seno del numero ingresado es: " + Math.Sin(numero).ToString("F2"));
    Console.WriteLine("El coseno del numero ingresado es: " + Math.Cos(numero).ToString("F2"));
    Console.WriteLine("La parte entera del numero ingresado es: " + Math.Truncate((double)numero));
}
else
{
    Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
}
Console.WriteLine("Ingrese dos números enteros:");
if (int.TryParse(Console.ReadLine(), out int num1) && int.TryParse(Console.ReadLine(), out int num2))
{
    Console.WriteLine("El numero mayor entre " + num1 + " y " + num2 + " es: " + Math.Max(num1, num2));
    Console.WriteLine("El numero menor entre " + num1 + " y " + num2 + " es: " + Math.Min(num1, num2));
}
else
{
    Console.WriteLine("Entrada no válida. Por favor, ingrese números enteros.");
}