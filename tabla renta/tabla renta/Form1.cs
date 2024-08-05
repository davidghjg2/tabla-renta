namespace tabla_renta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetPlaceholder();
        }
        private void SetPlaceholder()
        {
            txtSalarioNominal.Text = "Ingrese su salario";
            txtSalarioNominal.ForeColor = Color.Gray;
        }

        private void txtSalarioNominal_Enter(object sender, EventArgs e)
        {
            if (txtSalarioNominal.Text == "Ingrese su salario")
            {
                txtSalarioNominal.Text = string.Empty;
                txtSalarioNominal.ForeColor = Color.Black;
            }
        }

        private void txtSalarioNominal_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSalarioNominal.Text))
            {
                SetPlaceholder();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }
    }
}
