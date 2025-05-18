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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double Kilometros))
            {
                textBox2.Text = (Kilometros * 1000).ToString();
                textBox3.Text = (Kilometros * 39370.1).ToString();
                textBox4.Text = (Kilometros * 3280.84).ToString();
                textBox5.Text = (Kilometros * 0.621371).ToString();
                textBox6.Text = (Kilometros * 1093.61).ToString();
                textBox7.Text = (Kilometros * 100000).ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un numero que sea valido en kilometros");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
