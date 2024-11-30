using LocaMais.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMais.Domain.Entities
{
    public class Cidade : BaseEntity<int>
    {
        public Cidade()
        {
        }

        public Cidade(int id, string nome, string estado)
        {
            Id = id;
            Nome = nome;
            Estado = estado;
        }

        public string? Nome { get; set; }
        public string? Estado { get; set; }
    }

}
