using LocaMais.App.Base;
using LocaMais.App.Models;
using LocaMais.Domain.Base;
using LocaMais.Domain.Entities;
using LocaMais.Service.Validators;


namespace LocaMais.App.Cadastros
{
    public partial class CadastroCidade : CadastroBase
    {
        #region Declaração
        private readonly IBaseService<Cidade> _cidadeService;
        private List<CidadeModel>? cidades;
        #endregion

        #region Construtor
        public CadastroCidade(IBaseService<Cidade> cidadeService)
        {
            _cidadeService = cidadeService;
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private void PreencheObjeto(Cidade cidade)
        {
            cidade.Nome = txtNome.Text;
            cidade.Estado = cboEstado.Text;
        }
        #endregion

        #region CRUD
        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var cidade = _cidadeService.GetById<Cidade>(id);
                        PreencheObjeto(cidade);
                        cidade = _cidadeService.Update<Cidade, Cidade, CidadeValidator>(cidade);
                    }
                }
                else
                {
                    var cidade = new Cidade();
                    PreencheObjeto(cidade);
                    _cidadeService.Add<Cidade, Cidade, CidadeValidator>(cidade);
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
                _cidadeService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"LocaMais", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void CarregaGrid()
        {
            cidades = _cidadeService.Get<CidadeModel>().ToList();
            dataGridViewConsulta.DataSource = cidades;
            dataGridViewConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            cboEstado.Text = linha?.Cells["Estado"].Value.ToString();
        }
        #endregion


    }
}
