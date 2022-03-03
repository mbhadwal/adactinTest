using System;
using System.Windows.Forms;

namespace CalculatePremiumApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 view = new Form1(); //our view.
            PremiumModel model = new PremiumModel(); //our model
            PremiumController controller = new PremiumController(model, view); //our controller

            Application.Run(view);
        }
    }
}
