using LocaMais.App.Base;
using LocaMais.App.Models;
using LocaMais.Domain.Base;
using LocaMais.Domain.Entities;
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
            cboTipoImovel.DisplayMember = "NomeEstado";
            cboTipoImovel.DataSource = _cidadeService.Get<TipoImovelModel>().ToList();
        }

        private void PreencheObjeto(Imovel imovel)
        {
            
        }
        #endregion
    }
}
