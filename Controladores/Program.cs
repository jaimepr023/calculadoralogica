using claculadoralogica.Servicios;

namespace claculadoralogica
{
    /// <summary>
    /// Clase donde se encuentra nuestro metodo main.
    /// @autor jpr-111023
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo principal donde esta el esqueleto de nuestro programa.
        /// @autor jpr-111023
        /// </summary>
        /// <param name="args"></param>
        public static void Main(String[] args)
        {
            MenuInterfaz menuInterfaz = new MenuImplementacion();
            LogicaInterfaz logicaInterfaz = new LogicaImplementacion();
            menuInterfaz.mostrarMensaje();
            
            bool cerrarMenu = false;
            int opcionSelec;
            while (!cerrarMenu)
            {
                opcionSelec = menuInterfaz.devolverNumero();
                Console.WriteLine(opcionSelec);
                switch (opcionSelec)
                {
                    case 0:
                        Console.WriteLine("[INFO]-Se cerrara la aplicacion.");
                        cerrarMenu |= true; 
                        break;
                    case 1:
                        Console.WriteLine("[INFO]-Comprobará si las palabras escritas son iguales.");
                     string n1 = logicaInterfaz.nombreCaracter();
                     string n2 = logicaInterfaz.nombreCaracter();
                        logicaInterfaz.operIgualdad(n1 , n2);
                        break;
                    case 2:
                        Console.WriteLine("[INFO]- Comprobará si las palabras escritas son desiguales.");
                        string n3 = logicaInterfaz.nombreCaracter();
                        string n4 = logicaInterfaz.nombreCaracter();
                        logicaInterfaz.operDesigualdad(n3 , n4);
                        break;
                    default:
                        Console.WriteLine("[INFO]-Error en la aplicacion, por favor seleccione una opcion que exista\n");
                        break;
                }



            }

        }

    }
}
