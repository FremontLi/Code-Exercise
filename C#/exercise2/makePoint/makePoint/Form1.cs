using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace makePoint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b;//计算数
        string op;//操作符
        int  result;//结果

        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnJug_Click(object sender, EventArgs e)
        {
            string str = txtAnswer.Text;
            double d = double.Parse(str);
            string disp = "" + a + op + b + "=" + str + " ";
            if (d == result)
                disp += "√";
            else
                disp += "×";
            lstDisp.Items.Add(disp);
        }

        private void btnNew_Click(object sender, EventArgs e)//出题按钮
        {
            a = rnd.Next(9) + 1;//随机产生一个1-9的整数
            b = rnd.Next(9) + 1;
            int c = rnd.Next(4);//随机产生一个0-3的整数
            switch(c)
            {
                case 0: 
                    op = "+";result = a + b;break;
                case 1:
                    op = "-";result = a - b;break;
                case 2:
                    op = "*";result = a * b;break;
                case 3:
                    op = "/";result = a / b;break;
                default:
                    break;

            }
            lblA.Text = a.ToString();
            lblB.Text = op;
            lblC.Text = b.ToString();
            txtAnswer.Text = "";
        }
    }
}
