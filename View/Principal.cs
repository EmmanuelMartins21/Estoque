using Estoque.View;

namespace Estoque
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Editar editar = new Editar();
            editar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.ShowDialog();
        }
    }
}