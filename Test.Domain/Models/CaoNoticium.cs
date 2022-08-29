using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoNoticium
    {
        public int CoNoticia { get; set; }
        public string Assunto { get; set; }
        public string Descricao { get; set; }
        public string Foto { get; set; }
        public string CoUsuario { get; set; }
        public DateTime DtNoticia { get; set; }
    }
}
