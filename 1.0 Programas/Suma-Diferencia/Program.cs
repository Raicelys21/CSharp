using System;

namespace ITLAP3
{
    class Program
    {/* Realizar un programa que lea por teclado dos números, si el primero es mayor al segundo informar 
    su suma y diferencia, en caso contrario informar el producto y la división del primero respecto al segundo.*/

        static void Main(string[] args)
        {
            float num1, num2;
            float suma, prod, divi;

            Console.WriteLine("Ingresa numero uno: ");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa numero dos: ");
            num2 = float.Parse(Console.ReadLine());

            if (num1 > num2){
                Console.WriteLine($"El numero {num1} es mayor que {num2}.");
                suma = num1 + num2;
                Console.WriteLine($"La suma es igual a {suma}.");
            }
            else{
                prod = num1 / num2;
                divi = num1 * num2;
                Console.WriteLine($"El producto es {prod} y la division es {divi}.");
            }
        }
    }
}
