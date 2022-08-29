using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoFeriado
    {
        public byte? Dia { get; set; }
        public byte? Mes { get; set; }
        public int? Ano { get; set; }
    }
}
