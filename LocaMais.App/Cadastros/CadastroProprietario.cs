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
    public partial class CadastroProprietario : CadastroBase
    {
        #region Declaração
        private readonly IBaseService<Proprietario> _proprietarioService;
        private readonly IBaseService<Cidade> _cidadeService;

        private List<ProprietarioModel>? proprietarios;
        #endregion

        #region Construtor
        public CadastroProprietario(IBaseService<Proprietario> proprietarioService, IBaseService<Cidade> cidadeService)
        {
            _proprietarioService = proprietarioService;
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

        private void PreencheObjeto(Proprietario proprietario)
        {
            proprietario.Nome = txtNome.Text;
            proprietario.Cpf = txtCpf.Text;
            proprietario.Telefone = txtTelefone.Text;
            proprietario.Email = txtEmail.Text;
            proprietario.Endereco = txtEndereco.Text;
            proprietario.Bairro = txtBairro.Text;
            if (int.TryParse(cboCidade.SelectedValue.ToString(), out var idGrupo))
            {
                var cidade = _cidadeService.GetById<Cidade>(idGrupo);
                proprietario.Cidade = cidade;
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
                        var proprietario = _proprietarioService.GetById<Proprietario>(id);
                        PreencheObjeto(proprietario);
                        _proprietarioService.Update<Proprietario, Proprietario, ProprietarioValidator>(proprietario);
                    }
                }
                else
                {
                    var proprietario = new Proprietario();
                    PreencheObjeto(proprietario);
                    _proprietarioService.Add<Proprietario, Proprietario, ProprietarioValidator>(proprietario);
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
                _proprietarioService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"LocaMais", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            proprietarios = _proprietarioService.Get<ProprietarioModel>(new[] { "Cidade" }).ToList();
            dataGridViewConsulta.DataSource = proprietarios;
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
            txtEndereco.Text = linha?.Cells["Endereço"].Value.ToString();
            txtBairro.Text = linha?.Cells["Bairro"].Value.ToString();
            cboCidade.Text = linha?.Cells["Cidade"].Value.ToString();
        }
        #endregion

    }
}
