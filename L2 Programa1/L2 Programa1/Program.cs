using System;

class Program
{
    static void Main()
    {
        int num;
        double dec;
        string texto;
        bool boleano;

        Console.Write("Introduzca un número entero: ");
        num = int.Parse(Console.ReadLine());

        Console.Write("Introduzca un número decimal: ");
        dec = double.Parse(Console.ReadLine());

        Console.Write("Introduzca un texto: ");
        texto = Console.ReadLine();

        Console.Write("Introduzca un valor booleano (true/false): ");
        boleano = bool.Parse(Console.ReadLine());
    }
}
