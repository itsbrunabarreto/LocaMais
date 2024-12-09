using LocaMais.App.Base;
using LocaMais.App.Models;
using LocaMais.Domain.Base;
using LocaMais.Domain.Entities;
using LocaMais.Service.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocaMais.App.Cadastros
{
    public partial class CadastroImovel : CadastroBase
    {
        #region Declaração
        private readonly IBaseService<Imovel> _imovelService;
        private readonly IBaseService<Proprietario> _proprietarioService;
        private readonly IBaseService<TipoImovel> _tipoImovelService;
        private readonly IBaseService<Cidade> _cidadeService;

        private List<ImovelModel>? imoveis;
        #endregion
        public CadastroImovel(IBaseService<Imovel> imovelService, IBaseService<Proprietario> proprietarioService, IBaseService<TipoImovel> tipoImovelService, IBaseService<Cidade> cidadeService)
        {
            _imovelService = imovelService;
            _proprietarioService = proprietarioService;
            _tipoImovelService = tipoImovelService;
            _cidadeService = cidadeService;

            InitializeComponent();
            CarregarCombo();
        }

        #region Método
        private void CarregarCombo()
        {
            cboCidade.ValueMember = "Id";
            cboCidade.DisplayMember = "NomeEstado";
            cboCidade.DataSource = _cidadeService.Get<CidadeModel>().ToList();

            cboTipoImovel.ValueMember = "Id";
            cboTipoImovel.DisplayMember = "Nome";
            cboTipoImovel.DataSource = _tipoImovelService.Get<TipoImovelModel>().ToList();

            cboProprietario.ValueMember = "Id";
            cboProprietario.DisplayMember = "Nome";
            cboProprietario.DataSource = _proprietarioService.Get<ProprietarioModel>().ToList();
        }

        private void PreencheObjeto(Imovel imovel)
        {
            imovel.Nome = txtNome.Text;
            imovel.Endereco = txtEndereco.Text;
            imovel.Disponivel = chkDisponivel.Checked;

            if (float.TryParse(txtPrecoAluguel.Text, out var precoAluguel))
            {
                imovel.PrecoAluguel = precoAluguel;
            }
            if (int.TryParse(cboProprietario.SelectedValue.ToString(), out var idProprietario))
            {
                var proprietario = _proprietarioService.GetById<Proprietario>(idProprietario);
                imovel.Proprietario = proprietario;
            }
            if (int.TryParse(cboTipoImovel.SelectedValue.ToString(), out var idTipoImovel))
            {
                var tipoImovel = _tipoImovelService.GetById<TipoImovel>(idTipoImovel);
                imovel.TipoImovel = tipoImovel;
            }
            if (int.TryParse(cboCidade.SelectedValue.ToString(), out var idCidade))
            {
                var cidade = _cidadeService.GetById<Cidade>(idCidade);
                imovel.Cidade = cidade;
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
                        var imovel = _imovelService.GetById<Imovel>(id);
                        PreencheObjeto(imovel);
                        _imovelService.Update<Imovel, Imovel, ImovelValidator>(imovel);
                    }
                }
                else
                {
                    var imovel = new Imovel();
                    PreencheObjeto(imovel);
                    _imovelService.Add<Imovel, Imovel, ImovelValidator>(imovel);
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
                _imovelService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"LocaMais", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            
            imoveis = _imovelService.Get<ImovelModel>(new[] { "Cidade", "TipoImovel", "Proprietario" }).ToList();

            dataGridViewConsulta.DataSource = imoveis;

            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridViewConsulta.Columns["IdCidade"]!.Visible = false;
            dataGridViewConsulta.Columns["IdTipoImovel"]!.Visible = false;
            dataGridViewConsulta.Columns["IdProprietario"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtPrecoAluguel.Text = linha?.Cells["PrecoAluguel"].Value.ToString();
            txtEndereco.Text = linha?.Cells["Endereço"].Value.ToString();
            chkDisponivel.Checked = (bool)(linha?.Cells["Disponivel"].Value ?? false);

            cboCidade.Text = linha?.Cells["Cidade"].Value.ToString();
            cboTipoImovel.Text = linha?.Cells["TipoImovel"].Value.ToString();
            cboProprietario.Text = linha?.Cells["Proprietario"].Value.ToString();

        }
        #endregion
    }
}
