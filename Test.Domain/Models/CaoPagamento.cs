using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoPagamento
    {
        public ulong CoPagamento { get; set; }
        public string CoUsuario { get; set; }
        public string TpPagamento { get; set; }
        public DateTime DtPagamento { get; set; }
        public float VlPagamento { get; set; }
        public DateTime DtReferenciaPagamento { get; set; }
    }
}
