using System;

namespace Ejercicio4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite el ingreso de dos números y luego calcular:
            // -La resta si el primero es mayor que el segundo.
            // -La suma si son iguales.
            // -El producto si el primero es menor.
            // Se deberá emitir un cartel por pantalla con el resultado correspondiente.         
            
            int A, B, Resultado;

            Console.WriteLine("Introduce el primer numero");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero");
            B = int.Parse(Console.ReadLine());

            if (A > B){
                Resultado = A - B;
            }else{
                if (A == B){
                    Resultado = A + B;
                }else{
                    Resultado = A * B;
                }
            }

            Console.WriteLine("El resultado es: " + Resultado);

            Console.WriteLine("Fin del programa");
        }
    }
}
