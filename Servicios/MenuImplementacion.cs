using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claculadoralogica.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mostrarMensaje()
        {
            string mensaje = "Bienvenido a la calculadora lógica: \n";
            Console.WriteLine(mensaje);
        }

    }
}
