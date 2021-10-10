using System;

namespace ITLAP2
{
    class Program
    {
        /*Se ingresan tres valores por teclado, si todos son iguales 
        se imprime la suma del primero con el segundo y a este 
        resultado se lo multiplica por el tercero.*/
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            int suma;
            int mult;

            Console.WriteLine("Ingresa valor uno: ");
            num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa valor dos: ");
            num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa valor tres: ");
            num3 = Int32.Parse(Console.ReadLine());

            if(num1 == num2 && num2 == num3){
                
                suma = num1 + num2;
                mult = suma * num3;
                Console.WriteLine("La suma del valor uno y dos es : " + suma);
                Console.WriteLine("La multiplicacion de suma por el tercero : " + mult);
            }
        }
    }
}
