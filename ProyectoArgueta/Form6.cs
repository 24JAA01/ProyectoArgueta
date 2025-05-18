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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double yardas))
            {
                textBox2.Text = (yardas * 0.9144).ToString();
                textBox3.Text = (yardas * 36).ToString();
                textBox4.Text = (yardas * 3).ToString();
                textBox5.Text = (yardas * 0.000568182).ToString();
                textBox6.Text = (yardas * 0.0009144).ToString();
                textBox7.Text = (yardas * 91.44).ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un numero que sea valido en Yardas");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
