using System;
using System.Runtime.InteropServices; // <--- Para usar AllocConsole
using System.Windows.Forms;

namespace Proyecto
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AllocConsole(); // Abre la consola para ver Console.WriteLine

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
