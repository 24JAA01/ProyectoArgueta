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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double Metros))
            {
                textBox2.Text = (Metros * 39.3701).ToString();
                textBox3.Text = (Metros * 3.28084).ToString();
                textBox4.Text = (Metros * 0.000621371).ToString();
                textBox5.Text = (Metros * 1.09361).ToString();
                textBox6.Text = (Metros * 0.001).ToString();
                textBox7.Text = (Metros * 100).ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un numero que sea valido en metros");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
