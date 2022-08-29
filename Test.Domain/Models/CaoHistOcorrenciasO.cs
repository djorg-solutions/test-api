using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoHistOcorrenciasO
    {
        public int Idocorrencia { get; set; }
        public int? CoOs { get; set; }
        public string CoUsuario { get; set; }
        public DateTime? Data { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string Responsavel { get; set; }
        public DateTime? DataFechamento { get; set; }

        public virtual CaoO CoOsNavigation { get; set; }
        public virtual CaoUsuario CoUsuarioNavigation { get; set; }
    }
}
