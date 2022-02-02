using System;

namespace proyecto_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int Numero1 = 0;
            int Numero2 = 0;
            Console.WriteLine("introduzca el primer numero");
            //leo el primer numero.
            string lectura1 = Console.ReadLine();
            //convierto el primer numero a entero.
            Numero1 = Int32.Parse(lectura1);
            
            Console.WriteLine("introduzca el segundo numero");
            //leo el segundo numero.
            string lectura2 = Console.ReadLine();
            //convierto a entero el segundo numero.
            Numero2 = Int32.Parse(lectura2);

            int resultado = Numero1 + Numero2;
            Console.WriteLine("el resultado es:" + resultado.ToString());
            
            //comparo los numeros para saber si son iguales
            bool comparacion = false;
            comparacion = Numero1.Equals(Numero2);
            Console.WriteLine("el resultado es:" + comparacion.ToString());
            Console.ReadLine();


                



        }
    }
    
}