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
    public partial class CadastroTipoImovel : CadastroBase
    {
        #region Declarações
        private readonly IBaseService<TipoImovel> _tipoImovelService;
        private List<TipoImovelModel>? tiposImoveis;
        #endregion

        #region Construtor
        public CadastroTipoImovel(IBaseService<TipoImovel> tipoImovelService)
        {
            _tipoImovelService = tipoImovelService;
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private void PreencheObjeto(TipoImovel tipoImovel)
        {
            tipoImovel.Nome = txtNome.Text;
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
                        var tipoImovel = _tipoImovelService.GetById<TipoImovel>(id);
                        PreencheObjeto(tipoImovel);
                        tipoImovel = _tipoImovelService.Update<TipoImovel, TipoImovel, TipoImovelValidator>(tipoImovel);
                    }
                }
                else
                {
                    var tipoImovel = new TipoImovel();
                    PreencheObjeto(tipoImovel);
                    tipoImovel = _tipoImovelService.Add<TipoImovel, TipoImovel, TipoImovelValidator>(tipoImovel);
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
                _tipoImovelService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"LocaMais", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            tiposImoveis = _tipoImovelService.Get<TipoImovelModel>().ToList();
            dataGridViewConsulta.DataSource = tiposImoveis;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
        }
        #endregion


    }
}
