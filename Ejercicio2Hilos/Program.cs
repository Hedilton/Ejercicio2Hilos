using System;
using System.Collections.Generic;//contiene interfaces y clases que definen colecciones genericas,permiten estar tipadas
using System.Linq;//conjunto de extensiones integradas en c#,permite trabajar mas comodo
using System.Text;//contiene clases que representan codificaciones de caracteres
using System.Threading;

//Ingresar dos numeros y realizar operacion de suma, resta, multiplicacion y division
namespace Ejercicio2Hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] A = new int[2];
            Console.Write("Ingrese el primer numero: ");
            A[0] = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            A[1] = Int32.Parse(Console.ReadLine());
            Thread s = new Thread(suma);
            Thread r = new Thread(resta);
            Thread m = new Thread(multiplicacion);
            Thread d = new Thread(division);
            s.Start(A) ;
            r.Start(A);
            m.Start(A);
            d.Start(A);
        }
        static void suma(object A)
        {
            Int32[] numeros = (Int32[])A;
            int resultado = numeros[0] + numeros[1];
            Console.WriteLine("el resultado de la suma es: "+resultado);
        }
        static void resta(object A)
        {
            Int32[] numeros = (Int32[])A;
            int resultado = numeros[0] - numeros[1];
            Console.WriteLine("el resultado de la resta es: " + resultado);
        }
        static void multiplicacion(object A)
        {
            Int32[] numeros = (Int32[])A;
            int resultado = numeros[0] * numeros[1];
            Console.WriteLine("el resultado de la multiplicacion es: " + resultado);
        }
        static void division(object A)
        {
            Int32[] numeros = (Int32[])A;
            int resultado = numeros[0] / numeros[1];
            Console.WriteLine("el resultado de la division es: " + resultado);
        }
    }
}
