using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {

        private int ubicacionEstante;
        private Producto[] productos;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int ubicacion, int capacidad):this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos() 
        {
            return this.productos;
        }

        public static string MostrarEstantes(Estante e) 
        {
            StringBuilder sb = new StringBuilder();
            foreach (Producto item in e.GetProductos())
            { 
                sb.AppendLine(Producto.MostrarProducto(item));
            }
           
            return sb.ToString();
        }


        public static bool operator ==(Estante e, Producto p)
        {
            bool respuesta = false;
            foreach (Producto item in e.GetProductos())
            {
                if (item == p) 
                {
                    respuesta = true;
                }
            }

            return respuesta;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {

            foreach (Producto item in e.GetProductos())
            {
               
            }       

            return !(e == p);
        }

        public static Estante operator -(Estante e, Producto p)
        {

            return e;
        }




    }
}
