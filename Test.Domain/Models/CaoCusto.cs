using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoCusto
    {
        public ulong CoCusto { get; set; }
        public sbyte CoTipoCusto { get; set; }
        public string Descricao { get; set; }
        public sbyte CoEscritorio { get; set; }
        public DateTime? DtCompra { get; set; }
        public DateTime? DtPagamento { get; set; }
        public string CoBoleto { get; set; }
        public float Valor { get; set; }
        public string Parcela { get; set; }
        public bool? Pag { get; set; }
        public ulong CoCustoHigh { get; set; }
    }
}
