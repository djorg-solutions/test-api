using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoObsCliente
    {
        public uint CoObs { get; set; }
        public string Descricao { get; set; }
        public uint CoCliente { get; set; }
        public string CoUsuario { get; set; }
        public DateTime? DtObs { get; set; }
    }
}
