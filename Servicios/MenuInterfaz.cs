using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claculadoralogica.Servicios
{
    /// <summary>
    /// Cebecera de todos los metodos
    /// @autor jpr - 121023
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que escribe por pantalla el mensaje de bienvenida
        /// @autor jpr - 121023
        /// </summary>
        public void mostrarMensaje();

        /// <summary>
        /// Metodo que devuelve el numero que tu quieras elegir
        /// @autor jpr - 121023
        /// </summary>
        /// <returns></returns>
        public int devolverNumero();
    }
}
