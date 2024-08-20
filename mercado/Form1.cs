namespace mercado
{
    public partial class Form1 : Form
    { double valor2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            string pro = txtproduto.Text;
            double valor = double.Parse(txtvalor.Text);
            double qtd = double.Parse(txtqtd.Text);
            valor2 += qtd * valor;

            lista.Items.Add(pro + " / " + qtd + " / " + valor);
            txtproduto.Clear();
            txtvalor.Clear();
            txtqtd.Clear();
            txtproduto.Focus();

            txttotal.Text= valor2.ToString();


        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            valor2 = 0;
            txttotal.Text = valor2.ToString("c");

            lista.Items.Clear();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
