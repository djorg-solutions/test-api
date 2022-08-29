using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoPermissao
    {
        public string CoUsuario { get; set; }
        public string PermissaoIntervalo { get; set; }
        public string PermissaoHoraExtra { get; set; }

        public virtual CaoUsuario CoUsuarioNavigation { get; set; }
    }
}
