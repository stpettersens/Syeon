using System;
using System.Windows.Forms;

namespace Syeon
{
#if WINDOWS || XBOX
    static class Program
    {
        public static frmMain form;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            form = new frmMain();
            Syeon sim = new Syeon(form.getDrawSurface());
            form.Show();
            sim.Run();
        }
    }
#endif
}
