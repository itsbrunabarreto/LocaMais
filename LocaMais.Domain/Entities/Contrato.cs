using LocaMais.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMais.Domain.Entities
{
    public class Contrato : BaseEntity<int>
    {
        public Contrato() 
        {
        }

        public Contrato(int id, DateTime dataInicio, DateTime dataFim, float valorAluguel, Imovel? imovel, Inquilino? inquilino, Proprietario? proprietario)
        {
            Id = id;
            DataInicio = dataInicio;
            DataFim = dataFim;
            ValorAluguel = valorAluguel;
            Imovel = imovel;
            Inquilino = inquilino;
            Proprietario = proprietario;

        }
        public float? ValorAluguel { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public Imovel? Imovel { get; set; }
        public Inquilino? Inquilino { get; set; }
        public Proprietario? Proprietario { get; set; }
        public virtual Usuario? Usuario { get; set; }


    }
}
