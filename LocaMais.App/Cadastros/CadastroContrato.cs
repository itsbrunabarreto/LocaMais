using LocaMais.App.Base;
using LocaMais.App.Models;
using LocaMais.Domain.Base;
using LocaMais.Domain.Entities;
using LocaMais.Service.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocaMais.App.Cadastros
{
    public partial class CadastroContrato : CadastroBase
    {
        #region Declaração
        private readonly IBaseService<Contrato> _contratoService;
        private readonly IBaseService<Proprietario> _proprietarioService;
        private readonly IBaseService<Inquilino> _inquilinoService;
        private readonly IBaseService<Imovel> _imovelService;

        private List<ContratoModel>? contratos;
        #endregion

        #region Construtor
        public CadastroContrato(IBaseService<Contrato> contratoService, IBaseService<Proprietario> proprietarioService, IBaseService<Inquilino> inquilinoService, IBaseService<Imovel> imovelService)
        {
            _contratoService = contratoService;
            _proprietarioService = proprietarioService;
            _inquilinoService = inquilinoService;
            _imovelService = imovelService;

            InitializeComponent();
            CarregarCombo();
        }
        #endregion

        #region Método
        private void CarregarCombo()
        {
            cboInquilino.ValueMember = "Id";
            cboInquilino.DisplayMember = "Inquilino";
            cboInquilino.DataSource = _inquilinoService.Get<InquilinoModel>().ToList();

            cboProprietario.ValueMember = "Id";
            cboProprietario.DisplayMember = "Proprietario";
            cboProprietario.DataSource = _proprietarioService.Get<ProprietarioModel>().ToList();

            cboImovel.ValueMember = "Id";
            cboImovel.DisplayMember = "Proprietario";
            cboImovel.DataSource = _imovelService.Get<ImovelModel>().ToList();
        }

        private void PreencheObjeto(Contrato contrato)
        {
            if (float.TryParse(txtValorAluguel.Text, out var valorAluguel))
            {
                contrato.ValorAluguel = valorAluguel;
            }
            if (DateTime.TryParse(txtDataInicio.Text, out var dataInicio))
            {
                contrato.DataInicio = dataInicio;
            }
            if (DateTime.TryParse(txtDataFim.Text, out var dataFim))
            {
                contrato.DataFim = dataFim;
            }
            if (int.TryParse(cboProprietario.SelectedValue.ToString(), out var idProprietario))
            {
                var proprietario = _proprietarioService.GetById<Proprietario>(idProprietario);
                contrato.Proprietario = proprietario;
            }
            if (int.TryParse(cboInquilino.SelectedValue.ToString(), out var idInquilino))
            {
                var inquilino = _inquilinoService.GetById<Inquilino>(idInquilino);
                contrato.Inquilino = inquilino;
            }
            if (int.TryParse(cboImovel.SelectedValue.ToString(), out var idImovel))
            {
                var imovel = _proprietarioService.GetById<Imovel>(idImovel);
                contrato.Imovel = imovel;
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
                        var contrato = _inquilinoService.GetById<Contrato>(id);
                        PreencheObjeto(contrato);
                        _contratoService.Update<Contrato, Contrato, ContratoValidator>(contrato);
                    }
                }
                else
                {
                    var contrato = new Contrato();
                    PreencheObjeto(contrato);
                    _contratoService.Add<Contrato, Contrato, ContratoValidator>(contrato);
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
                _contratoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"LocaMais", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            contratos = _contratoService.Get<ContratoModel>(new[] { "Proprietario", "Inquilino", "Imovel" }).ToList();
            dataGridViewConsulta.DataSource = contratos;

            dataGridViewConsulta.Columns["ValorAluguel"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["IdProprietario"]!.Visible = false;
            dataGridViewConsulta.Columns["IdInquilino"]!.Visible = false;
            dataGridViewConsulta.Columns["IdImovel"]!.Visible = false;

        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            
            cboInquilino.Text = linha?.Cells["Inquilino"].Value.ToString();
            cboProprietario.Text = linha?.Cells["Proprietario"].Value.ToString();
            cboImovel.Text = linha?.Cells["Imovel"].Value.ToString();
            txtDataInicio.Text = DateTime.TryParse(linha?.Cells["DataCompra"].Value.ToString(), out var dataI)
               ? dataI.ToString("g")
               : "";
            txtDataFim.Text = DateTime.TryParse(linha?.Cells["DataCompra"].Value.ToString(), out var dataF)
               ? dataF.ToString("g")
               : "";
        }
        #endregion
    }
}
