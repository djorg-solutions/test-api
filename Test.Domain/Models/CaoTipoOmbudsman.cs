using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoTipoOmbudsman
    {
        public CaoTipoOmbudsman()
        {
            CaoOmbudsmen = new HashSet<CaoOmbudsman>();
        }

        public sbyte Idtipo { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<CaoOmbudsman> CaoOmbudsmen { get; set; }
    }
}
