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
            Cal_Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           
            
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Number1 = Convert.ToInt32(textBox1.Text);
            int Number2 = Convert.ToInt32(textBox2.Text);
            int CalCulate = Number1 + Number2;
            //1 method to convert int to string and store in  label
            //string Ans = Convert.ToString(CalCulate);
            //Cal_Display.Text = Ans;
            //2 method is use methos =>  ToString()
            Cal_Display.Text = CalCulate.ToString();

        }

        private void Cal_Display_Click(object sender, EventArgs e)
        {

        }
    }
}
