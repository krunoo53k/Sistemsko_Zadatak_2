using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Sistemsko_Zad_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button.CheckForIllegalCrossThreadCalls = false;
        }
        private void openApp(string appName, Button button)
        {
            button.Enabled = false;
            Process process = Process.Start(appName);
            process.WaitForExit();
            button.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => openApp("notepad", notepadButton));
            thread.Start();
        }

        private void paintButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => openApp("mspaint.exe", paintButton));
            thread.Start();
        }

        private void cmdButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => openApp("cmd", cmdButton));
            thread.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
