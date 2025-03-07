﻿// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;

Calculadora calc = new Calculadora();
int opcion = 0;
do
{
    Console.WriteLine(">>>>Calculadora<<<<");
    Console.WriteLine(">>Elija una opcion:");
    Console.WriteLine("1-Suma");
    Console.WriteLine("2-Resta");
    Console.WriteLine("3-Multiplicacion");
    Console.WriteLine("4-Division");
    Console.WriteLine("5-Limpiar");
    Console.WriteLine("6-Salir");
    string opcionIngresada = Console.ReadLine();
    if (int.TryParse(opcionIngresada, out opcion) && (opcion >= 1 && opcion <= 6))
    {
        Console.WriteLine("Ingrese el valor a operar: ");
        string valorIngresado = Console.ReadLine();
        double valor;
        if (double.TryParse(valorIngresado, out valor))
        {
            switch (opcion)
            {
                case 1:
                    calc.Sumar(valor);
                    Console.WriteLine($"Total: {calc.Resultado()}");
                    break;
                case 2:
                    calc.Restar(valor);
                    Console.WriteLine($"Total: {calc.Resultado()}");
                    break;
                case 3:
                    calc.Multiplicar(valor);
                    Console.WriteLine($"Total: {calc.Resultado()}");
                    break;
                case 4:
                    calc.Dividir(valor);
                    Console.WriteLine($"Total: {calc.Resultado()}");
                    break;
                case 5:
                    calc.Limpiar();
                    Console.WriteLine($"Total: {calc.Resultado()}");
                    break;
                case 6:
                    Console.WriteLine("Salir...");
                    opcion = 0;
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }
        }
    }else{
        Console.WriteLine("Opcion incorrecta");
    }

} while (opcion != 0);
