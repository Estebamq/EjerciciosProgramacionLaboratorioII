using System;

namespace Entidades
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;



        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
                
        }



        public string GetMarca() 
        {
            return this.marca;
        }

        public static string MostrarProducto(Producto p) 
        {
            return $" marca: {p.marca}, precio: {p.precio}, codigo de barra: {(string)p}";

        }

        public static explicit operator string(Producto p) 
        {
            return p.codigoDeBarra;

        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            return (p1.codigoDeBarra == p2.codigoDeBarra && p1.marca==p2.marca);
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }


        public static bool operator ==(Producto p1, string marcaRecibida)
        {
            return (p1.marca == marcaRecibida);
        }

        public static bool operator !=(Producto p1, string marcaRecibida)
        {
            return !(p1 == marcaRecibida);
        }




    }
}
