using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claculadoralogica.Servicios
{
    /// <summary>
    /// Clase de la logica con los metodos logicos
    ///  @autor jpr - 121023
    /// </summary>
    internal class LogicaImplementacion : LogicaInterfaz
    {
        public string nombreCaracter()
        {
            Console.WriteLine("Introduzca la siguente expresion:");
           string nomb1= Console.ReadLine();
            return nomb1;   
        }

        public void operIgualdad(string nom1, string nom2)
        {
           if(nom1 == nom2)
            {
                Console.WriteLine("Resultado de la igualdad: true\n");
            }
            else
            {
                Console.WriteLine("Resultado de la igualdad: false\n");
            }

        }
        public void operDesigualdad(string nom3, string nom4)
        {
            if (nom3 != nom4)
            {
                Console.WriteLine("Resultado de la desigualdad: true\n");
            }
            else
            {
                Console.WriteLine("Resultado de la desigualdad: false\n");
            }

        }

    }
}
