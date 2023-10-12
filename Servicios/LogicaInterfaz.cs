using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claculadoralogica.Servicios
{
    /// <summary>
    /// Cabecera de los metodos logicos
    ///  @autor jpr - 121023
    /// </summary>
    internal interface LogicaInterfaz
    {
        /// <summary>
        /// Metodo que devuelve el string de los caracteres dados por el usuario
        ///  @autor jpr - 121023
        /// </summary>
        /// <returns></returns>

        public string nombreCaracter();

        /// <summary>
        /// Metodo que escribe por pantalla si los caracteres son iguales
        ///  @autor jpr - 121023
        /// </summary>
        /// <param name="nom1"></param>
        /// <param name="nom2"></param>
        /// <returns></returns>
        public void operIgualdad(string nom1, string nom2);

        /// <summary>
        ///  Metodo que escribe por pantalla si los caracteres son desigualesiguales
        ///  @autor jpr -121023
        /// </summary>
        /// <param name="nom2"></param>
        /// <param name="nom3"></param>
        public void operDesigualdad(string nom3, string nom4);
    }

}
