using System;

namespace ConsoleAppPrimeraClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaro variables
            int numero;
            string numeroConsola;
            bool numeroValido;
            int numeroMaximo;
            int numeroMinimo;
            int contador;

            //inicializo variables
            numeroMaximo = int.MinValue;
            numeroMinimo = int.MaxValue;
            contador = 0;


            do
            {
                //valido el ingreso de numero
                do
                {
                    Console.WriteLine($"ingrese el {contador+1} numero");
                    numeroConsola = Console.ReadLine();
                    numeroValido = int.TryParse(numeroConsola, out numero);
                } while (!numeroValido);
                
                
                //si es maximo el numero ingresado lo guardo en la varible numeroMaximo
                if (numero>numeroMaximo) 
                {
                    numeroMaximo = numero;
                }

                //si es minimo el numero ingresado lo guardo en la variable numeroMinimo
                if (numero < numeroMinimo) 
                {
                    numeroMinimo = numero;
                }

                contador++;
            } while (contador<5);

            //muestro el numero maximo y el numero minimo ingresado
            Console.WriteLine($"el numero Maximo ingresado es {numeroMaximo} y el numero minimo ingresado es {numeroMinimo}");
            Console.ReadKey();
            

        }
    }
}
