

namespace CartolaFCClone
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Inicializar a configura��o da aplica��o, se necess�rio
            ApplicationConfiguration.Initialize();

            // Iniciar o formul�rio principal da aplica��o
            Application.Run(new Principal());
        }
    }
}