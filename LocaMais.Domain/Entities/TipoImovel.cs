using LocaMais.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMais.Domain.Entities
{
    public class TipoImovel : BaseEntity<int>
    {
        public TipoImovel() 
        {
        }

        public TipoImovel(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }

        public string? Nome { get; set; }
    }
}
