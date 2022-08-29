using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoOsObsChamado
    {
        public int CoObs { get; set; }
        public int? CoChamado { get; set; }
        public string CoUsuario { get; set; }
        public string Descricao { get; set; }
        public DateTime? DtObs { get; set; }
        public string Email { get; set; }
        public string ArquivoObs { get; set; }
    }
}
