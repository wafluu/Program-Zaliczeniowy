using System;
using System.Windows.Forms;

namespace Zuk_Zaliczenie
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread] // Wymagane dla Windows Forms
        static void Main()
        {
            Application.EnableVisualStyles(); // Włącza nowoczesny wygląd kontrolek
            Application.SetCompatibleTextRenderingDefault(false); // Standardowe renderowanie tekstu
            Application.Run(new Form1()); // Uruchamia główny formularz
        }
    }
}