using Microsoft.Scripting.Hosting;
using IronPython.Hosting;
using System.Windows.Forms;
using System;

namespace Syeon
{
    class ScriptingEngine
    {
        private const string SSE = "Syeon scripting engine";
        private ScriptEngine engine = Python.CreateEngine();
        private ScriptSource e_script = null;
        private ScriptScope scope = null;

        /// <summary>
        /// Load the core module that offers access to the simulation environment.
        /// </summary>
        public void LoadCoreModule()
        {
            scope = engine.CreateScope();

            // Allow scriptable access to...
            scope.SetVariable("status", Program.form.toolStripStatus);  // Statusbar.
            scope.SetVariable("log", Program.form.txtLog); // Simulation log.
            try 
            {     
                e_script = engine.CreateScriptSourceFromFile("syeon.py");
                e_script.Execute(scope);
            }
            catch(Exception e)
            {
                DialogResult ans = MessageBox.Show(
                e.Message, SSE, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                if(ans == DialogResult.Abort) 
                {
                    Program.form.Close();
                }
                else if(ans == DialogResult.Retry)
                {
                    LoadCoreModule(); // Recursion rules!
                }
            }
        }
        
        /// <summary>
        /// Load the simulation script.
        /// </summary>
        /// <param name="script"></param>
        public void LoadSimulationScript(string script)
        {
            e_script = engine.CreateScriptSourceFromString(script);
            try
            {
                e_script.Execute(scope);
            }
            catch (Exception e)
            {
                MessageBox.Show
                (e.Message, SSE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void StopScript()
        {
            // TODO...
        }
    }
}
