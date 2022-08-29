using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoClienteContato
    {
        public uint CoCliente { get; set; }
        public DateTime? DtContato { get; set; }
        public uint? FgAgendado { get; set; }
        public TimeSpan? HrIni { get; set; }
        public TimeSpan? HrEnd { get; set; }
    }
}
