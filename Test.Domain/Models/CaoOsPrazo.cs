using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoOsPrazo
    {
        public int CoPrazo { get; set; }
        public int? CoOs { get; set; }
        public uint? CoFase { get; set; }
        public int? TotalAnalista { get; set; }
        public int? TotalHora { get; set; }
    }
}
