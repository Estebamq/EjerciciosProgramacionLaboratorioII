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

        public string GetTitular()
        {
            return this.titular;
        }

        public decimal GetCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            return $"el nombre del titular es {this.titular} y la cantidad es {this.cantidad}";
        }


        public void Ingresar(decimal cantidadIngresante)
        {
            if(cantidadIngresante > 0) 
            {
                this.cantidad += cantidadIngresante;
            }
        }

        public void Retirar(decimal cantidadARetirar)
        {
          
             this.cantidad -= cantidadARetirar;
           
        }

    }
}
