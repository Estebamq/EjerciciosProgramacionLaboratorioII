using System;
using Logica;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Cuenta cuentaUno = new Cuenta("Esteban",500000);

            Console.WriteLine($"Los datos son: {cuentaUno.Mostrar()}");

            cuentaUno.Ingresar(3000);

            Console.WriteLine($"Los datos son: {cuentaUno.Mostrar()}");

            cuentaUno.Retirar(50000);

            Console.WriteLine($"Los datos son: {cuentaUno.Mostrar()}");


            Console.ReadKey();
        }
    }
}
