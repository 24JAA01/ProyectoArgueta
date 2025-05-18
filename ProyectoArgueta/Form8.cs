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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double centimetros))
            {
                textBox2.Text = (centimetros * 0.01).ToString();
                textBox3.Text = (centimetros * 0.393701).ToString();
                textBox4.Text = (centimetros * 0.0328084).ToString();
                textBox5.Text = (centimetros * 0.0000062137).ToString();
                textBox6.Text = (centimetros * 0.0109361).ToString();
                textBox7.Text = (centimetros * 0.00001).ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un numero que sea valido en Centimetros");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
