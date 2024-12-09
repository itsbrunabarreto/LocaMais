using LocaMais.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMais.App.Models
{
    public class ContratoModel
    {
        public float ValorAluguel { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int? IdImovel { get; set; }
        public string? Imovel { get; set; }
        public int? IdInquilino { get; set; }
        public string? Inquilino { get; set; }
        public int? IdProprietario { get; set; }
        public string? Proprietario { get; set; }
    }
}
