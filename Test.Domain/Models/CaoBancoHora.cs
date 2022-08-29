using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoBancoHora
    {
        public uint CoBancHoras { get; set; }
        public string CoUsuario { get; set; }
        public string Periodo { get; set; }
        public int MinMes { get; set; }
        public int MinFerias { get; set; }
        public int MinPago { get; set; }
        public int MinTotal { get; set; }
    }
}
