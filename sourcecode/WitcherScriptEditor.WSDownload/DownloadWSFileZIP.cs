using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WitcherScriptEditor.DownloadWSFile
{
    class FileDownWS
    {
       public void DownloadFileWS()
       {
            WebClient client = new WebClient();
            client.DownloadFile("https://download1586.mediafire.com/0sc2feorz7hg/je424f2n6r6hrbt/WSFiles.zip", @"C:\WitcherScriptEditor\WSFiles.zip");
       }
    }
    class ExtractZIPFile
    {
        public void ZIPFileWS()
        {
            Directory.CreateDirectory(@"C:\WitcherScriptEditor\WSFiles");
            ZipFile.ExtractToDirectory(@"C:\WitcherScriptEditor\WSFiles.zip", @"C:\WitcherScriptEditor\WSFiles");
            MessageBox.Show("Extracting WS Files is Completed", "Witcher Script Editor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if(MessageBox.Show("Do you want to copy WS Files?", "Witcher Script Editor", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                   ProcessStartInfo proc = new ProcessStartInfo();
                   proc.FileName = "cmd.exe";
                   proc.Verb = "runas";
                   proc.Arguments = @"/c robocopy C:\WitcherScriptEditor\WSFiles C:\WitcherScriptEditor *.ws";
                   proc.WindowStyle = ProcessWindowStyle.Hidden;
                   Process.Start(proc);
                   MessageBox.Show("Done, your WS Files is Copied to Directory WitcherScriptEditor", "Witcher Script Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MessageBox.Show("Now you can edit scripts for game The Witcher 3", "Witcher Script Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
               DirectoryInfo xxx = new DirectoryInfo(@"C:\WitcherScriptEditor\WSFiles");
               FileInfo[] xjan = xxx.GetFiles("*.ws");
               foreach(FileInfo bnz in xjan)
               {
                 bnz.Delete();
               }
            Directory.Delete(@"C:\WitcherScriptEditor\WSFiles");
        }
    }
}
