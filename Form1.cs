namespace PRACTICA_6
{
    public partial class Form1 : Form
    {
        private float floatvalor1;
        private float floatvalor2;
        private int floatvalor3;
        private int valor1;
        private int valor2;
        private object valor3;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            floatvalor1 = float.Parse(textBox1.Text);
            floatvalor2 = float.Parse(textBox2.Text);
            floatvalor3 = valor1 * valor2 / 2;
            textBox3.Text = valor3.ToString();
        }
    }
}