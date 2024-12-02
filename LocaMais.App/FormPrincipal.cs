using LocaMais.App.Cadastros;
using LocaMais.App.Infra;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace LocaMais.App
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroCidade>();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroUsuario>();
        }

        private void tipoImóvelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroTipoImovel>();
        }

        private void próprietárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroProprietario>();
        }

        private void inquilinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroInquilino>();
        }

        private void ExibeFormulario<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormulario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}
