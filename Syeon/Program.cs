using System;
using System.Windows.Forms;

namespace Syeon
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            frmMain form = new frmMain();
            form.Show();
            Syeon sim = new Syeon(form.getDrawSurface());
            sim.Run();
        }
    }
#endif
}
