using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class PermissaoSistema
    {
        public string CoUsuario { get; set; }
        public ulong CoTipoUsuario { get; set; }
        public ulong CoSistema { get; set; }
        public string InAtivo { get; set; }
        public string CoUsuarioAtualizacao { get; set; }
        public DateTime DtAtualizacao { get; set; }
    }
}
