using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



    namespace 第一个
{
    public partial class form1 : Form
    {
        int k = 0;
        int a;
        int sum = 0;
        
        int[] M = new int[100];
        //public int sum = 0;
        public form1()
        {
            InitializeComponent();
            //this.textBox4.KeyDown += new KeyEventHandler(textBox4_KeyDown);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = int.Parse(textBox1.Text);
            int inCircle = 0;
            Random r = new Random();
            for(int i=0;i<p;i++)
            {
                double x = r.NextDouble();
                double y = r.NextDouble();
                if ((x * x + y * y) <= 1.0)
                    inCircle++;
            }
            double ans = 4.0 * inCircle / p;
            textBox2.Text = ans + "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1.Text = "投射点数";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //k = int.Parse(textBox4.Text);
            //sum += k;
            a = int.Parse(textBox4.Text);
            for (int i = 0; i < a; i++)
            {
                Random r = new Random(Guid.NewGuid().GetHashCode());
                int t = r.Next(0, 10);
                M[i] = t;
                sum += M[i];
            }
        }

        
        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox3.Text = sum + " ";
            sum = 0;
            string ll = null;
            for (int i=0; i<a;i++)
            {
                ll = ll + M[i]+" ";
            }

            textBox5.Text = ll;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = null;
        }


    }
}
