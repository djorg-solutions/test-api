using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoOsFase
    {
        public int CoFase { get; set; }
        public string Descricao { get; set; }
        public string DescricaoIngl { get; set; }
        public int? Ordem { get; set; }
    }
}
