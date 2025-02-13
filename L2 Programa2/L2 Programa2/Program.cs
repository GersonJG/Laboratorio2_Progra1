using System;

class Program
{
    static void Main()
    {
        int num1, num2, suma, resta, multi, div;
        Console.Write("Digite el primer numero: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite el segundo numero: ");
        num2 = int.Parse(Console.ReadLine());

        suma = num1 + num2;
        resta = num1 - num2;
        multi = num1 * num2;
        div = num1 / num2;

        Console.Write("El resultado de la suma es: " + suma);
        Console.Write("\nEl resultado de la resta es: " + resta);
        Console.Write("\nEl resultado de la multiplicacion es: " + multi);
        Console.Write("\nEl resultado de la division es: " + div);


        decimal dec1, dec2, dsuma, dresta, dmulti, ddiv;
        Console.Write("\n\nDigite el primer numero: ");
        dec1 = int.Parse(Console.ReadLine());

        Console.Write("Digite el segundo numero: ");
        dec2 = int.Parse(Console.ReadLine());

        dsuma = dec1 + dec2;
        dresta = dec1 - dec2;
        dmulti = dec1 * dec2;
        ddiv = dec1 / dec2;

        Console.Write("El resultado de la suma es: " + dsuma);
        Console.Write("\nEl resultado de la resta es: " + dresta);
        Console.Write("\nEl resultado de la multiplicacion es: " + dmulti);
        Console.Write("\nEl resultado de la division es: " + ddiv);

        float f1, f2, fsuma, fresta, fmulti, fdiv;
        Console.Write("\n\nDigite el primer numero: ");
        f1 = float.Parse(Console.ReadLine());

        Console.Write("Digite el segundo numero: ");
        f2 = float.Parse(Console.ReadLine());

        fsuma = f1 + f2;
        fresta = f1 - f2;
        fmulti = f1 * f2;
        fdiv = f1 / f2;

        Console.Write("El resultado de la suma es: " + fsuma);
        Console.Write("\nEl resultado de la resta es: " + fresta);
        Console.Write("\nEl resultado de la multiplicacion es: " + fmulti);
        Console.Write("\nEl resultado de la division es: " + fdiv);

        short snum1, snum2, ssuma, sresta, smulti, sdiv;
        Console.Write("\n\nDigite el primer numero: ");
        snum1 = short.Parse(Console.ReadLine());

        Console.Write("Digite el segundo numero: ");
        snum2 = short.Parse(Console.ReadLine());

        ssuma = (short)(snum1 + snum2);
        sresta = (short)(snum1 - snum2);
        smulti = (short)(snum1 * snum2);
        sdiv = (short)(snum1 / snum2);

        Console.Write("El resultado de la suma es: " + ssuma);
        Console.Write("\nEl resultado de la resta es: " + sresta);
        Console.Write("\nEl resultado de la multiplicacion es: " + smulti);
        Console.Write("\nEl resultado de la division es: " + sdiv);

        byte bnum1, bnum2, bsuma, bresta, bmulti, bdiv;
        Console.Write("\n\nDigite el primer numero: ");
        bnum1 = byte.Parse(Console.ReadLine());

        Console.Write("Digite el segundo numero: ");
        bnum2 = byte.Parse(Console.ReadLine());

        bsuma = (byte)(bnum1 + bnum2);
        bresta = (byte)(bnum1 - bnum2);
        bmulti = (byte)(bnum1 * bnum2);
        bdiv = (byte)(bnum1 / bnum2);

        Console.Write("El resultado de la suma es: " + bsuma);
        Console.Write("\nEl resultado de la resta es: " + bresta);
        Console.Write("\nEl resultado de la multiplicacion es: " + bmulti);
        Console.Write("\nEl resultado de la division es: " + bdiv);

    }
}
