namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoForm : Form
    {
        private Compromisso compromisso;
        public Compromisso Compromisso
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtAssunto.Text = value.Assunto;
                txtLocal.Text = value.Local;
                txtData.Text = value.Data;
                txtInicio.Text = value.Inicio;
                txtTermino.Text = value.Termino;
            }
            get
            {
                return  compromisso;
            }
        }

      

        public TelaCompromissoForm()
        {
            InitializeComponent();
        }
        public void TelaCompromissoForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string assunto = txtAssunto.Text;
            string local = txtLocal.Text;
            string data = txtData.Text;
            string inicio = txtInicio.Text;
            string termino = txtTermino.Text;

            compromisso = new Compromisso(assunto, local, data, inicio, termino);

            List<string> erros = compromisso.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
