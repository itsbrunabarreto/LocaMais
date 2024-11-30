using LocaMais.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMais.Domain.Entities
{
    public class Usuario : BaseEntity<int>
    {
        public Usuario()
        {
        }

        public Usuario(int id, string nome, string senha, string login, string email, DateTime dataCadastro, DateTime dataLogin, bool status)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            Login = login;
            Email = email;
            DataCadastro = dataCadastro;
            DataLogin = dataLogin;
            Status = status;
        }

        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public string? Login { get; set; }
        public string? Email { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataLogin { get; set; }
        public bool Status { get; set; }

    }
}
