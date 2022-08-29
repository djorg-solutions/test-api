using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoSalarioPag
    {
        public int IdPagamento { get; set; }
        public string CoUsuario { get; set; }
        public DateTime DtEfetuado { get; set; }
        public string Status { get; set; }
        public string Observacao { get; set; }

        public virtual CaoUsuario CoUsuarioNavigation { get; set; }
    }
}
