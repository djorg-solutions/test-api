using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class TipoUsuario
    {
        public ulong CoTipoUsuario { get; set; }
        public string DsTipoUsuario { get; set; }
        public ulong CoSistema { get; set; }
    }
}
