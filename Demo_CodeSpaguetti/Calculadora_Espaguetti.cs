using System;

namespace Demo_CodeSpaguetti
{
    class Calculadora_Espaguetti
    {
        public static void Main()
        {
            Console.WriteLine("\n-------------------- Kaizen Force -----------------------\n");

            Console.WriteLine("Bienvenido a la calculadora Spaghetti\n");
            Console.WriteLine("-------------------------------------\n");
    
            Int32 Nro_1, Nro_2, Operador;

            Console.WriteLine("Por favor, introduzca el primer número : ");
            Nro_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------\n");

            Console.WriteLine("Por favor, introduzca el segundo número : ");
            Nro_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------\n");

            Console.WriteLine("Por favor, ingrese operación a  realizar : \n");
            Console.WriteLine("     1 => Para sumar\n");
            Console.WriteLine("     2 => Para restar\n");
            Console.WriteLine("     3 => Para multiplicar\n");
            Console.WriteLine("     4 => Para dividir\n");

            Operador = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------------------------------------\n");

            int resultado = 0;

            if (Operador==1)
            {
                resultado = Nro_1 + Nro_2;
            }
            else if(Operador == 2)
            {
                resultado = Nro_1 - Nro_2;
            }
            else if (Operador == 3)
            {
                resultado = Nro_1 * Nro_2;
            }
            else if (Operador == 4)
            {
                resultado = Nro_1 / Nro_2;
            }

            Console.WriteLine("El resultado de la operación es : " + resultado.ToString() + "\n");


            Console.WriteLine("-------------------- Kaizen Force -----------------------\n");

            Console.WriteLine("Presione tecla r para reiniciar\n");

            string reiniciar = Console.ReadLine();

            if (reiniciar == "r")
            {
                Console.Clear();
                Main();
            }


            Console.ReadKey();
        }
    }
}
