

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
            // Inicializar a configuração da aplicação, se necessário
            ApplicationConfiguration.Initialize();

            // Iniciar o formulário principal da aplicação
            Application.Run(new Principal());
        }
    }
}