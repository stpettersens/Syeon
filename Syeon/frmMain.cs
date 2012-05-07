using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
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
                    engine.LoadSimulationScript(rtScriptText.Text);
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

        private void SaveScriptAs(string fileName, bool newFile)
        {
            string fn = fileName;
            string sfn = tabFiles.SelectedTab.Text;
            if (newFile)
            {
                saveFileDialog.FileName = fn.Substring(0, fn.Length - 1); // Remove the asterix for filename in dialog
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fn = saveFileDialog.FileName;
                    sfn = saveFileDialog.FileName;
                }
            }
            StreamWriter sw = new StreamWriter(fn, false, Encoding.UTF8);
            sw.Write(rtScriptText.Text);
            sw.Close();
            tabFiles.SelectedTab.Text = sfn.Substring(0, sfn.Length - 1); // Remove the asterix in short file name when saving; 
            toolStripStatus.Text = "Saved -> " + fn;
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
                sr.Close();
                tabFiles.SelectedTab.Text = openFileDialog.SafeFileName;
                files.Add(openFileDialog.FileName);
                toolStripStatus.Text = "Loaded -> " + openFileDialog.FileName;
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            engine.LoadCoreModule();
        }

        private void rtScriptText_TextChanged(object sender, EventArgs e)
        {
            if (rtScriptText.TextLength > 0)
            {
                btnRunStop.Enabled = true;
                if (!tabFiles.SelectedTab.Text.Contains("*"))
                {
                    tabFiles.SelectedTab.Text += "*";
                }
            }
            else btnRunStop.Enabled = false;
        }

        private void saveSimulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tabFiles.SelectedTab.Text.Contains("*"))
            {
                string fileName = tabFiles.SelectedTab.Text;
                if(fileName.Contains("[")) SaveScriptAs(fileName, true);
                else SaveScriptAs(files[tabFiles.SelectedIndex], false);
            }
        }
    }
}
