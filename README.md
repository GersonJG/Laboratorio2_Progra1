# Laboratorio2_Progra1

Preguntas:
1. Los operadores logicos se utilizan para poder comprobar si una accion se cumple o si es valida o no. Esto
a traves de los valores de true and falso.

2. Es importantes definir el tipo de dato que contendra una variable para evitar problemas a futuro. Ademas,
sirve para identificar cual es su uso, operar segun el tipo de dato y evitar confusiones durante el desarrollo.

## Enunciado 1

```C#:
using System;

class Program
{
    static void Main()
    {
        int edad;
        Console.WriteLine("Ingrese su edad: ");
        edad = int.Parse(Console.ReadLine());

        if (edad > 0 && edad < 12)
        {
            Console.WriteLine("Usted es un niño");
        }
        else if (edad >= 12 && edad < 18)
        {
            Console.WriteLine("Usted es un adolescente");
        }
        else if (edad >= 18 && edad < 60)
        {
            Console.WriteLine("Usted es un adulto");
        }
        else
        {
            Console.WriteLine("Usted es un adulto mayor");
        }
    }
}
```
+ Usaria el tipo de Estructura if-else. Esto con el onjetivo de poder agregar condiciones especificas
y contemplar un numero de casos limitados y no tan extensos.

## Enunciado 2

```C#:
using System;

class Program{

    static void Main(){

        int num;
        Console.WriteLine("Ingrese un numero del 1 al 7:");
        num = int.Parse(Console.ReadLine());

        switch(num){
            case 1:
            Console.WriteLine("Lunes");
            break;
            
            case 2:
            Console.WriteLine("Martes");
            break;

            case 3:
            Console.WriteLine("Miercoles");
            break;

            case 4:
            Console.WriteLine("Jueves");
            break;

            case 5:
            Console.WriteLine("Viernes");
            break;

            case 6:
            Console.WriteLine("sabado");
            break;

            case 7:
            Console.WriteLine("Domingo");
            break;

            default:
            Console.WriteLine("Numero Invalido");
            break;            
        }

    }
}
```
+ En este caso se utiliza la lista switch. Esto se debe a que hay una gran cantidad de variables y no es 
necesario hacer alguna operacion extra como una comparacion logica como lo puede ser > o <.

## Enunciado 3

```C#:
using System;
class Program{
    static void Main(){

        string user = "juan123";
        string contra = "password123";

        string user2, contra2;
        Console.WriteLine("Ingrese su usuario: ");
        user2 = Console.ReadLine();
        Console.WriteLine("Ingrese su contrasena: ");
        contra2 = Console.ReadLine();

        if (user == user2 && contra == contra2){
            Console.WriteLine("Acceso Concedido");
        }

        else if (user == user2 && contra != contra2 ){
            Console.WriteLine("Contrasena Incorrecta");
        }

        else {
            Console.WriteLine("Usuario no Registrado");
        }

    }
}
```
+ En este caso utilizo el if-else. De la misma manera que el primer ejemplo, en este caso utilizo if-else
para hacer algunas comparaciones y utilizar operadores logicos como el **AND**.