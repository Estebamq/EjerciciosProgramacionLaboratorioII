using System;
using System.Text;

namespace Logica
{
   
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;

        }

        /// <summary>
        /// obtiene el nombre del titular
        /// </summary>
        /// <returns>nombre del titular</returns>
        public string GetTitular()
        {
            return this.titular;
        }

        /// <summary>
        /// obtiene la cantidad que posee el titular
        /// </summary>
        /// <returns>Cantidad de dinero</returns>
        public decimal GetCantidad()
        {
            return this.cantidad;
        }

        /// <summary>
        /// Muestra los datos de la cuenta
        /// </summary>
        /// <returns>un string con los datos</returns>
        public string Mostrar()
        {
            return $"el nombre del titular es {this.titular} y la cantidad es {this.cantidad}";
        }


        /// <summary>
        /// Se utiliza para ingresar mas cantidad de dinero a la cuenta
        /// </summary>
        /// <param name="cantidadIngresante">una cantidad de dinero</param>
        public void Ingresar(decimal cantidadIngresante)
        {
            if(cantidadIngresante > 0) 
            {
                this.cantidad += cantidadIngresante;
            }
        }


        /// <summary>
        /// Se utiliza para debitar una cantidad en la cuenta
        /// </summary>
        /// <param name="cantidadARetirar">una cantidad de dinero</param>
        public void Retirar(decimal cantidadARetirar)
        {
          
             this.cantidad -= cantidadARetirar;
           
        }

    }
}
