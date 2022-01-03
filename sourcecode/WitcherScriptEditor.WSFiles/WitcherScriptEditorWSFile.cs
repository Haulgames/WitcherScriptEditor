using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WitcherScriptEditor.WSFile
{
    class WSFileReadFiles
    {
        public void WSFileRead()
        {
            File.ReadAllText("*.ws");
            DirectoryInfo wsfile = new DirectoryInfo(@"C:\WitcherScriptEditor");
            FileInfo[] wsfilews = wsfile.GetFiles("*.ws");
            foreach (FileInfo ws in wsfilews)
            {
                ws.Open(FileMode.OpenOrCreate);
                if (!(wsfile.Exists))
                {
                    Debug.Write("This directory is detected!!!");
                }
            }
        }
    }
    class WSFileWriteFiles
    {
        public void WSWriteFile()
        {
            File.OpenWrite("*.ws");
        }
    }
    class CreateWSFile
    {
        public void CreateWSFileEditor()
        {
            File.WriteAllText(@"C:\WitcherScriptEditor\script.ws", $"{null}", Encoding.Unicode);
            Process.Start("notepad", @"C:\WitcherScriptEditor\script.ws"); //just to be sure this file is created successfully :D
            if (Process.GetProcesses().Length == 0)
            {
                Debug.Write("Notepad not found or any text editor not found");
            }
        }
    }
}
