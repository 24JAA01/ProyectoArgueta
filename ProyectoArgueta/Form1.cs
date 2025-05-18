namespace ProyectoArgueta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 d = new Form3();
            d.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 x = new Form4();
            x.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 p = new Form5();
            p.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 j = new Form6();
            j.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 l = new Form7();
            l.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.ShowDialog();
        }
    }
}
