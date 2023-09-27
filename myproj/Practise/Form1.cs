using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace myproj.Practise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int CountChar() {
            int count = 0;
            StreamReader streamReader = new StreamReader(@"C:\Users\nsreevani\Desktop\training\test.txt");
            string content = streamReader.ReadToEnd();
            count = content.Length;
            Thread.Sleep(5000);
            return count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "PROCESSING FILE..";
            int count = CountChar();
            label1.Text = count.ToString(); 
        }

        private  void Form1_Load(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Text = "counting characters";
        }

        static void Main() {
            Form1 f = new Form1();
        }
    }
}
