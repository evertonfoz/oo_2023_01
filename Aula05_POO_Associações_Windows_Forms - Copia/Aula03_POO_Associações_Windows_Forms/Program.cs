using Aula03_POO_Associações_Windows_Forms.Apresentacao;

namespace Aula03_POO_Associações_Windows_Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new EstudanteForm());
        }
    }
}