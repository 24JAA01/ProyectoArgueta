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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double Millas))
            {
                textBox2.Text = (Millas * 1609.34).ToString();
                textBox3.Text = (Millas * 63360).ToString();
                textBox4.Text = (Millas * 5280).ToString();
                textBox5.Text = (Millas * 1760).ToString();
                textBox6.Text = (Millas * 1.60934).ToString();
                textBox7.Text = (Millas * 160934).ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un numero que sea valido en Millas");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
