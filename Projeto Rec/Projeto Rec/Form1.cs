using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Rec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 3;
            int b = 5;
            int z = metodo1(a, b);
            //quanto velerá o z?
            MessageBox.Show(z.ToString());
        }

        int metodo1(int x, int y)
        {
            x = x * y;
            return x;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //10, 9, 8, 7, 6, 5, 4, 3, 2, 1
            String x = "";
            for(int i = 10; i > 0; i--)
            {
                x += i + " ";
            }

            MessageBox.Show(x);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //gerar um loop que roda "30" vezes:
            int i;
            for (i = 1; i < 30; i++)
            {
                //...
            }

            MessageBox.Show(i.ToString());
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }
    }
}
