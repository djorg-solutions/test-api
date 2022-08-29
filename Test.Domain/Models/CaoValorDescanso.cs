using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoValorDescanso
    {
        public int Id { get; set; }
        public string CoUsuario { get; set; }
        public string Segundos { get; set; }
        public string MesReferencia { get; set; }
    }
}
