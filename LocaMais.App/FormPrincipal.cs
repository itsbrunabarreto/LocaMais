using LocaMais.App.Cadastros;
using LocaMais.App.Infra;
using LocaMais.App.Outros;
using LocaMais.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace LocaMais.App
{
    public partial class FormPrincipal : MaterialForm
    {
        public static Usuario Usuario { get; set; }
        public FormPrincipal()
        {
            InitializeComponent();
            CarregaLogin();
        }

        private void CarregaLogin()
        {
            var login = ConfigureDI.ServicesProvider!.GetService<Login>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    lblUsuario.Text = $"Usuario: {Usuario.Nome}";
                }
            }
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

        private void imóvelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroImovel>();
        }

        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroContrato>();

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
