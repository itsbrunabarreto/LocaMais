using LocaMais.Domain.Base;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMais.Domain.Entities
{
    public class Inquilino : BaseEntity<int>
    {
        public Inquilino() 
        {
        }

        public Inquilino (int id, string nome,string cpf, string telefone, string endereco, string bairro, string email, Cidade cidade)
        {
            Id = id;
            Nome = nome;  
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
            Bairro = bairro;
            Cidade = cidade;
             
        }

        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public string? Endereco { get; set; }
        public string? Bairro { get; set; }
        public Cidade? Cidade { get; set; }
    }
}
