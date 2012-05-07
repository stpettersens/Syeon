using Microsoft.Scripting.Hosting;
using IronPython.Hosting;
using System.Windows.Forms;
using System;

namespace Syeon
{
    class ScriptingEngine
    {
        private ScriptEngine engine = Python.CreateEngine();
        private ScriptSource e_script = null;
        
        public dynamic LoadSimulationScript(string script)
        {
            e_script = engine.CreateScriptSourceFromString(script);
            try
            {
                return e_script.Execute();
            }
            catch (Exception e)
            {
                MessageBox.Show
                (e.Message, "Syeon scripting engine", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "Script aborted.";
        }

        public void StopScript()
        {
            // TODO...
            e_script.GetCode();
        }
    }
}
