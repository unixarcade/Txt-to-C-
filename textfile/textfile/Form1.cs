// Generator Made By: Luminosity
// http://luminosity.livejournal.com

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputfilename;
            string outputfilename;
            int counter = 0;
            string line;
          inputfilename = textBox1.Text;
           outputfilename = textBox2.Text;

            //open files
            System.IO.StreamReader file = new System.IO.StreamReader("c:\\test\\" + inputfilename + ".txt");
           System.IO.StreamWriter file2 = new System.IO.StreamWriter("c:\\test\\" + outputfilename + ".txt");
            // start region
            file2.WriteLine(" #region "+ inputfilename + " ");
            while ((line = file.ReadLine()) !=null)
            {
               
                Console.WriteLine(line);
                file2.WriteLine("Console.WriteLine(\" " + line + " \" );" );
                
                counter++;
            }
            // ending code region
            file2.WriteLine("#endregion");

            // close files
            file.Close();
            file2.Close();
            MessageBox.Show("Generation Completed");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://luminosity.livejournal.com");
        }
    }
}
