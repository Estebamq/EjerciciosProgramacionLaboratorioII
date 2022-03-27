using System;

namespace Logica
{
    public static class Validador
    {
        /// <summary>
        /// Valida que la respuesta sea el caracter 'S'
        /// </summary>
        /// <param name="respuesta"></param>
        /// <returns>true si es 'S'</returns>
        public static bool ValidarRespuesta(string respuesta) 
        {
            return respuesta == "S";
        }

    }
}
