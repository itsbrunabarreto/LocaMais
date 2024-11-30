using LocaMais.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMais.Domain.Entities
{
    public class Proprietario : BaseEntity<int>
    {
        public Proprietario() 
        {
        }

        public Proprietario(int id, string nome, string telefone, string endereco, string bairro, string cpf, string email, Cidade cidade)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Bairro = bairro;
            Cpf = cpf;
            Email = email;
            Cidade = cidade;

        }

        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Endereco { get; set; }
        public string? Bairro { get; set; }
        public string? Cpf { get; set; }
        public string? Email { get; set; }
        public Cidade? Cidade { get; set; }
    }
}
