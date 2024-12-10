using LocaMais.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMais.Domain.Entities
{
    public class Imovel : BaseEntity<int>
    {

        public Imovel() 
        {
        }

        public Imovel(int id, string nome, string endereco, float precoAluguel, bool disponivel, Proprietario? proprietario, TipoImovel? tipoImovel, Cidade? cidade)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            PrecoAluguel = precoAluguel;
            Disponivel = disponivel;
            Proprietario = proprietario;
            TipoImovel = tipoImovel;
            Cidade = cidade;
        }

        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public float? PrecoAluguel { get; set; }
        public bool? Disponivel { get; set; }
        public Proprietario? Proprietario { get; set; }
        public TipoImovel? TipoImovel { get; set; }
        public Cidade? Cidade { get; set; }        
    }
}
