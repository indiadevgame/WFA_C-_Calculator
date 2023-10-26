using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WFA
{
    public partial class Form : System.Windows.Forms.Form
    {
        
        
        public Form()
        {
            InitializeComponent();
           
           
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            progressBar1.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int progressbar_val = Convert.ToInt32(textBox1.Text);
            progressBar1.Increment(progressbar_val);
            int interval_val = Convert.ToInt32(textBox2.Text);
            timer1.Interval = (interval_val); ;
        }
    }
}
