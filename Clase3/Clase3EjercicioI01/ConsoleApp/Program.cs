using System;
using Logica;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //creo una cuenta nueva con datos
            Cuenta cuentaUno = new Cuenta("Esteban",500000);


            //utilizo el metodo mostrar para ver los datos
            Console.WriteLine($"Los datos son: {cuentaUno.Mostrar()}");

            //ingreso mas cantidad a la cuenta
            cuentaUno.Ingresar(3000);

            
            Console.WriteLine($"Los datos son: {cuentaUno.Mostrar()}");

            //debito cantidad de la cuenta
            cuentaUno.Retirar(50000);

            //muestro los datos finales
            Console.WriteLine($"Los datos son: {cuentaUno.Mostrar()}");


            Console.ReadKey();
        }
    }
}
