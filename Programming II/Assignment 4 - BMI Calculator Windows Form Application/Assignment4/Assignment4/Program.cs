using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SplashScreen splashScreen = new SplashScreen();
            splashScreen.Show();

            BMICalc BMICalc = new BMICalc();

            // Close the splash screen after a few seconds and show the main form
            splashScreen.timer1.Tick += (s, e) =>
            {
                splashScreen.Hide();
                splashScreen.timer1.Stop();
            };
            splashScreen.timer1.Start();

            Application.Run();
        }
    }
}
