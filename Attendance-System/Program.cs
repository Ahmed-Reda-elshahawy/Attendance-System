
using Attendance_System.Forms;
using Attendance_System.PresentationLayer.Forms;

namespace Attendance_System
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
            //Application.Run(new MainForm());
            Application.Run(new Login());

        }
    }
}