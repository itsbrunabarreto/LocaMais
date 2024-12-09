using LocaMais.App.Base;
using LocaMais.App.Models;
using LocaMais.Domain.Base;
using LocaMais.Domain.Entities;
using LocaMais.Service.Validators;


namespace LocaMais.App.Cadastros
{
    public partial class CadastroInquilino : CadastroBase
    {
        #region Declaração
        private readonly IBaseService<Inquilino> _inquilinoService;
        private readonly IBaseService<Cidade> _cidadeService;

        private List<InquilinoModel>? inquilinos;
        #endregion

        #region Construtor
        public CadastroInquilino(IBaseService<Inquilino> inquilinoService, IBaseService<Cidade> cidadeService)
        {
            _inquilinoService = inquilinoService;
            _cidadeService = cidadeService;

            InitializeComponent();
            CarregarCombo();
        }
        #endregion

        #region Método
        private void CarregarCombo()
        {
            cboCidade.ValueMember = "Id";
            cboCidade.DisplayMember = "NomeEstado";
            cboCidade.DataSource = _cidadeService.Get<CidadeModel>().ToList();
        }

        private void PreencheObjeto(Inquilino inquilino)
        {
            inquilino.Nome = txtNome.Text;
            inquilino.Cpf = txtCpf.Text;
            inquilino.Telefone = txtTelefone.Text;
            inquilino.Email = txtEmail.Text;
            inquilino.Endereco = txtEndereco.Text;
            inquilino.Bairro = txtBairro.Text;
            if (int.TryParse(cboCidade.SelectedValue.ToString(), out var idGrupo))
            {
                var cidade = _cidadeService.GetById<Cidade>(idGrupo);
                inquilino.Cidade = cidade;
            }
        }
        #endregion

        #region Eventos CRUD
        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var inquilino = _inquilinoService.GetById<Inquilino>(id);
                        PreencheObjeto(inquilino);
                        _inquilinoService.Update<Inquilino, Inquilino, InquilinoValidator>(inquilino);
                    }
                }
                else
                {
                    var inquilino = new Inquilino();
                    PreencheObjeto(inquilino);
                    _inquilinoService.Add<Inquilino, Inquilino, InquilinoValidator>(inquilino);
                }
                TabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"LocaMais", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _inquilinoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"LocaMais", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            inquilinos = _inquilinoService.Get<InquilinoModel>(new[] { "Cidade" }).ToList();
            dataGridViewConsulta.DataSource = inquilinos;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["IdCidade"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtCpf.Text = linha?.Cells["CPF"].Value.ToString();
            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
            txtEndereco.Text = linha?.Cells["Endereco"].Value.ToString();
            txtBairro.Text = linha?.Cells["Bairro"].Value.ToString();
            cboCidade.Text = linha?.Cells["Cidade"].Value.ToString();
        }
        #endregion
    }
}
