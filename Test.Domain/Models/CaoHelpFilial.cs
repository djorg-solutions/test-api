using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoHelpFilial
    {
        public uint CoFilial { get; set; }
        public string NoFilial { get; set; }
        public int CoCliente { get; set; }
        public string Estado { get; set; }
    }
}
