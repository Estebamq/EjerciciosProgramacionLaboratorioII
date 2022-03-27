using System;

namespace LogicaDeNegocios
{
    public static class Validador
    {
        /// <summary>
        /// valida el ingreso de un valor usando 
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static bool Validar(int valor, int min, int max) 
        {
            if(valor>= min && valor<= max) 
            {
                return true;
            }

            return false;



            /* //otra forma
            
             return valor>= min && valor<= max;
            */
        }

    }
}
