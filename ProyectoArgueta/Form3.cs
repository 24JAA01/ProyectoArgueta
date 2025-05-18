using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoArgueta
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double pulgadas))
            {
                textBox2.Text = (pulgadas * 0.0254).ToString();
                textBox3.Text = (pulgadas * 0.0833333).ToString();
                textBox4.Text = (pulgadas * 0.000015783).ToString();
                textBox5.Text = (pulgadas * 0.0277778).ToString();
                textBox6.Text = (pulgadas * 0.0000254).ToString();
                textBox7.Text = (pulgadas * 2.54).ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un numero que sea valido en Pulgadas");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
