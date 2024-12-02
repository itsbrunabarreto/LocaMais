using LocaMais.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMais.App.Models
{
    public class ImovelModel
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public float PrecoAluguel { get; set; }
        public bool Disponivel { get; set; }
        public int IdProprietario { get; set; }
        public string Proprietario { get; set; }
        public int IdTipoImovel { get; set; }
        public string TipoImovel { get; set; }
        public int IdCidade { get; set; }
        public string Cidade { get; set; }
    }
}
