namespace práctica_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Radio, Altura;
            double Basearea, Lateralarea, Totalarea;
            double Volumen;

            Radio = double.Parse(textBox1.Text);
            Altura = double.Parse(textBox2.Text);

            Basearea = Radio * Radio * Math.PI;
            Lateralarea = 2 * Math.PI * Radio * Altura;
            Totalarea = 2 * Math.PI * Radio * (Altura + Radio);
            Volumen = Math.PI * Radio * Radio * Altura;

            textBox3.Text = Basearea.ToString("0.##");
            textBox4.Text = Lateralarea.ToString("0.##");
            textBox5.Text = Totalarea.ToString("0.##");
            textBox6.Text = Volumen.ToString("0.##");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}