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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double Pies))
            {
                textBox2.Text = (Pies * 0.3048).ToString();
                textBox3.Text = (Pies * 12).ToString();
                textBox4.Text = (Pies * 0.000189394).ToString();
                textBox5.Text = (Pies * 0.333333).ToString();
                textBox6.Text = (Pies * 0.0003048).ToString();
                textBox7.Text = (Pies * 30.48).ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un numero que sea valido en Pies");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
