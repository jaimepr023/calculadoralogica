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
            menuInterfaz.mostrarMensaje();
            
            bool cerrarMenu = false;
            while (!cerrarMenu)
            {

            }

        }

    }
}
