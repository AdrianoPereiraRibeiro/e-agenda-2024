using eAgenda.WinApp.ModuloContato;

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
                comboContato.SelectedItem = value.Contato;
            }
            get
            {
                return compromisso;
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
            Contato contato = (Contato)comboContato.SelectedItem;
            string localizacao = null;
            if (radioButton1.Checked) { localizacao = radioButton1.Text; }
            else { localizacao = radioButton2.Text; }

            compromisso = new Compromisso(assunto, local, data, inicio, termino, contato, localizacao);

            List<string> erros = compromisso.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboContato.Enabled = true;
            }
            else
            {
                comboContato.Enabled = false;
                comboContato.Items.Clear();
            }

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboContato_SelectedIndexChanged(object sender, EventArgs e)
        {
          

           comboContato.Items.Clear();

            RepositorioContato repositorio = new RepositorioContato();
            repositorio.SelecionarTodos();
            
                comboContato.Items.Add(repositorio);
        }
    }
}
