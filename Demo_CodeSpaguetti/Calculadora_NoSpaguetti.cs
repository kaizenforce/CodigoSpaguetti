using System;

namespace Demo_CodeSpaguetti
{
    class Calculadora_NoSpaguetti
    {

        public static void Main()
        {
            MuestraBienvenida();
            AgregaLineaDivisoria();
            IniciaCalculadora();
        }

        public static void MuestraBienvenida()
        {
            Console.WriteLine("\n-------------------- Kaizen Force -----------------------\n");
            Console.WriteLine("Bienvenido a la calculadora No Spaghetti refactorizada\n");            
        }

        public static void AgregaLineaDivisoria()
        {
            Console.WriteLine("-------------------------------------\n");
        }

        public static void IniciaCalculadora()
        {

            Int32 Nro_1, Nro_2, Operador, Resultado;
            
            Nro_1 = ObtenerNro(1);

            AgregaLineaDivisoria();

            Nro_2 = ObtenerNro(2);

            AgregaLineaDivisoria();

            Operador = ObtenerOperador();

            AgregaLineaDivisoria();

            Resultado = CalcularResultado(Nro_1, Nro_2, Operador);

            MostrarResultado(Resultado);

            HabilitarReinicioProceso();
        }

        public static int ObtenerNro(int nro)
        {

            string orden = "invalido";
            if (nro == 1)
            {
                orden = "primer";
            }
            else if (nro == 2) {
                orden = "segundo";
            } 

            Console.WriteLine("Por favor, introduzca el " + orden + " número : ");

            return Convert.ToInt32(Console.ReadLine());

        }

        public static int ObtenerOperador()
        {
            Console.WriteLine("Por favor, ingrese operación a  realizar : \n");
            Console.WriteLine("     1 => Para sumar\n");
            Console.WriteLine("     2 => Para restar\n");
            Console.WriteLine("     3 => Para multiplicar\n");
            Console.WriteLine("     4 => Para dividir\n");

            return Convert.ToInt32(Console.ReadLine());
        }

        public static int CalcularResultado(int nro_1, int nro_2, int operador)
        {
            int resultado = 0;

            switch (operador)
            {
                case 1: 
                    resultado = nro_1 + nro_2;
                    break;
                case 2:
                    resultado = nro_1 - nro_2;
                    break;
                case 3:
                    resultado = nro_1 * nro_2;
                    break;
                case 4:
                    resultado = nro_1 / nro_2;
                    break;
                default:
                    break;
            }

            return resultado;

        }

        public static void MostrarResultado(int resultado)
        {
            Console.WriteLine("El resultado de la operación es : " + resultado.ToString() + "\n");
            
            Console.WriteLine("-------------------- Kaizen Force -----------------------\n");
        }

        public static void HabilitarReinicioProceso()
        {
            Console.WriteLine("Presione tecla r para reiniciar\n");

            string reiniciar = Console.ReadLine();

            if (reiniciar == "r")
            {
                Console.Clear();
                Main();
            }
        }

    }
}
