using System;
using Logica;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            int numero;
            string numeroString;
            int acumuladorNumero=0;

            do
            {
                //pido el ingreso de datos
                Console.WriteLine("ingrese un numero: ");
                numeroString = Console.ReadLine();
                
                //convierto el string a un entero y lo acumulo
                int.TryParse(numeroString, out numero);
                acumuladorNumero += numero;

               
                Console.WriteLine("¿Desea continuar? (S/N)");
                respuesta = Console.ReadLine();

            } while (Validador.ValidarRespuesta(respuesta));

            Console.WriteLine($"El resultado de la suma de numeros es: {acumuladorNumero}");

        }
    }
}
