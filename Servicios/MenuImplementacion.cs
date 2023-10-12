using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace claculadoralogica.Servicios
{
    /// <summary>
    /// Clase donde conecta la interfaz con la implementacion.
    /// @autor jpr - 121023
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {

        
        public void mostrarMensaje()
        {
            string mensaje = "Bienvenido a la calculadora lógica: \n";
            Console.WriteLine(mensaje);  
        }
        public int devolverNumero()
        {
            int escogerOpcion;
            Console.WriteLine("################################");
            Console.WriteLine("Opcion 0. Cerrar menú");
            Console.WriteLine("Opcion 1. Igualdad");
            Console.WriteLine("Opcion 2. Desigualdad");
            Console.WriteLine("################################ \n");
            Console.WriteLine("Seleccione una opcion:");
            escogerOpcion = Console.ReadKey(true).KeyChar - ('0');
            return escogerOpcion;
        }

    }
}
