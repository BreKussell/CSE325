using System;
using System.Windows.Forms;

namespace MegaDesk_Russell
{
    static class Program
    {
 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Specify the startup form (MainMenu in this case)
            Application.Run(new MainMenu());
        }
    }
}
