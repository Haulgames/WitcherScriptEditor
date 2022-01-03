using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WitcherScriptEditor.WSFile;
using WitcherScriptEditor.DownloadWSFile;

namespace WitcherScriptEditor
{
    public partial class WitcherScriptEditor : Form
    {
        public WitcherScriptEditor()
        {
            InitializeComponent();
            Directory.CreateDirectory(@"C:\WitcherScriptEditor");
            MainMenu WSEditor1 = new MainMenu();
            MenuItem AboutWSEditor = WSEditor1.MenuItems.Add("&About");
            AboutWSEditor.MenuItems.Add(new MenuItem("&About this program", new EventHandler(this.About_Clicked), Shortcut.ShiftF3));
            this.Menu = WSEditor1;
            textBox1.ScrollBars = ScrollBars.Horizontal;
            textBox1.ScrollBars = ScrollBars.Vertical;
        }
        private void About_Clicked(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\WitcherScriptEditor\Aboutthisprogram.txt", "This is My First Program: Witcher Script Editor, Written in C#... \nThis is a program that YOU can edit the script for The Witcher 3 and my program free to use");
            Process.Start("notepad", @"C:\WitcherScriptEditor\Aboutthisprogram.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateWSFile wsFile = new CreateWSFile(); //Automatic Creating WS File
            wsFile.CreateWSFileEditor(); //WS File!!!
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileDownWS wsFile = new FileDownWS();
            wsFile.DownloadFileWS();
            MessageBox.Show("WS Files is Downloaded Successfully");
            ExtractZIPFile file = new ExtractZIPFile();
            file.ZIPFileWS();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Copy textBox1 Text to WS File
            Clipboard.SetText(textBox1.Text);
            File.WriteAllText(@"C:\WitcherScriptEditor\script.ws", $"{Clipboard.GetText()}", Encoding.Unicode); //Creating script.ws file to WitcherScriptEditor Directory 
            MessageBox.Show("Save Successfully Completed!!!", "Witcher Script Editor", MessageBoxButtons.OK, MessageBoxIcon.None);
            Process.Start("notepad", @"C:\WitcherScriptEditor\script.ws"); //Start notepad for modding The Witcher 3
            Debug.Write("WS successfully created in Directory WitcherScriptEditor");
        }
}   }
