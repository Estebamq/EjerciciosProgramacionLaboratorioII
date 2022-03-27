using System;
using LogicaDeNegocios;

namespace Consola
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int numero;
            string numeroString;
            int acumulador = 0;
            int numeroMaximo = int.MinValue;
            int numeroMinimo = int.MaxValue;



            for (int i = 0; i < 10; i++)
            {
                //valido el ingreso del dato
                do
                {
                    Console.WriteLine($"ingrese el  {i + 1} numero");
                    numeroString = Console.ReadLine();
                    
                } while (!int.TryParse(numeroString, out numero) && !Validador.Validar(numero, -100, 100));

                //si es maximo el numero ingresado lo guardo en la varible numeroMaximo
                if (numero > numeroMaximo)
                {
                    numeroMaximo = numero;
                }

                //si es minimo el numero ingresado lo guardo en la variable numeroMinimo
                if (numero < numeroMinimo)
                {
                    numeroMinimo = numero;
                }

                acumulador += numero;

            }

           
            Console.WriteLine($"El valor minimo ingresado es: {numeroMinimo}, el valor maximo ingresado es: {numeroMaximo} y el promedio es: {acumulador/10}");
            Console.ReadKey();
        }
    }
}
