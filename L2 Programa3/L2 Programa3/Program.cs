﻿using System;

class Program
{
    static void Main()
    {
        int num1, num2;
        Console.Write("Digite el primer número: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite el segundo número: ");
        num2 = int.Parse(Console.ReadLine());

        if (num1 > num2 && num2 < num1)
        {
            Console.WriteLine("El número mayor es: " + num1);
        }
        else if (num1 < num2)
        {
            Console.WriteLine("El número mayor es: " + num2);
        }
        else
        {
            Console.WriteLine("Los números son iguales");

        }
    }
}
