// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a = 10;
// b = a;
// Console.WriteLine("valor de a:" + a);
// Console.WriteLine("valor de b:" + b);

//ejercicio 1
// int numero;
// Console.WriteLine("ingrese un número entero mayor que 0:");
// if (int.TryParse(Console.ReadLine(), out numero) && numero > 0)
// {
//     int aux;

//     int numeroInvertido = 0;
//     while (numero > 0)
//     {
//         aux = numero % 10;
//         numeroInvertido = (numeroInvertido * 10) + aux;
//         numero = numero / 10;
//     }
//     Console.WriteLine("El número invertido es: " + numeroInvertido);

// }
// else
// {
//     Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
// }

//ejercicio 2
int opcion;
Console.WriteLine(Calculadora V1);
Console.WriteLine(Ingrese una opción(1suma, 2resta, 3multiplcación 4división));
if (int.TryParse(Console.ReadLine(), out opcion) && opcion = 1 && opcion = 4)
{
    Console.WriteLine(Ingrese el primer número);
    if (double.TryParse(Console.ReadLine(), out double num1))
    {
        Console.WriteLine(Ingrese el segundo número);
        if (double.TryParse(Console.ReadLine(), out double num2))
        {
            double resultado = 0;
            switch (opcion)
            {
                case 1
                    resultado = num1 + num2;
                    Console.WriteLine(El resultado de la suma es + resultado);
                    break;
                case 2
                    resultado = num1 - num2;
                    Console.WriteLine(El resultado de la resta es + resultado);
                    break;
                case 3
                    resultado = num1  num2;
                    Console.WriteLine(El resultado de la multiplicación es + resultado);
                    break;
                case 4
                    if (num2 != 0)
                    {
                        resultado = num1  num2;
                        Console.WriteLine(El resultado de la división es + resultado);
                    }
                    else
                    {
                        Console.WriteLine(Error No se puede dividir por cero.);
                    }
                    break;
            }
        }
        else
        {
            Console.WriteLine(Entrada no válida.Por favor, ingrese un número.);
        }
    }
    else
    {
        Console.WriteLine(Entrada no válida.Por favor, ingrese un número.);
    }
}
else
{
    Console.WriteLine(Opción no válida.Por favor, ingrese una opción entre 1 y 4.);
}