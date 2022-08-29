using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoOsOb
    {
        public int CoObs { get; set; }
        public int? CoOs { get; set; }
        public string CoUsuario { get; set; }
        public string Descricao { get; set; }
        public DateTime? DtObs { get; set; }
    }
}
