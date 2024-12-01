using LocaMais.App.Base;
using LocaMais.App.Models;
using LocaMais.Domain.Base;
using LocaMais.Domain.Entities;


namespace LocaMais.App.Cadastros
{
    public partial class CadastroUsuario : CadastroBase
    {
        #region Declarações
        private readonly IBaseService<Usuario> _usuarioService;
        private List<UsuarioModel>? usuarios;
        #endregion

        #region Construtor
        public CadastroUsuario(IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
        }
        #endregion
    }
}
