using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminHotel
{
    internal static class MainApp
    {
    /// <summary>
    /// Главная точка входа для приложения.
    /// </summary>
    [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Беремо інформацію по апартаментам з файлу
            AppartmentsList.InitArr();

            Application.Run(new MainForm());
            
        }
    }
}
