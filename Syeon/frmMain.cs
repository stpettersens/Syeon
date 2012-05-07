using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Syeon
{
    public partial class frmMain : Form
    {
        private ScriptingEngine engine;
        private List<string> files;
        private bool running;

        public frmMain()
        {
            InitializeComponent();
            running = false;
            engine = new ScriptingEngine();
            files = new List<string>();
            btnRunStop.Enabled = true;
        }

        public IntPtr getDrawSurface()
        {
            return pctSimSurface.Handle;
        }

        private void toggleSimulation()
        {
            if (rtScriptText.TextLength > 0)
            {
                if (!running)
                {
                    running = true;
                    if(rdoClearLog.Checked) txtLog.Clear();
                    txtLog.Text += String.Format("[{0}]\r\n",
                    engine.LoadSimulationScript(rtScriptText.Text)
                    );
                    running = false;
                }
                else
                {
                    engine.StopScript();
                    running = false;
                }
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openSimulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {       
                StreamReader sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                rtScriptText.Clear();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    rtScriptText.Text += line + "\r\n";
                }
                tabFiles.SelectedTab.Text = openFileDialog.SafeFileName;
                files.Add(openFileDialog.FileName);
            }
        }

        private void runStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toggleSimulation();
        }

        private void btnRunStop_Click(object sender, EventArgs e)
        {
            toggleSimulation();
        }
    }
}
