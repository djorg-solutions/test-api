using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoCategoriasOmbudsman
    {
        public CaoCategoriasOmbudsman()
        {
            CaoOmbudsmen = new HashSet<CaoOmbudsman>();
        }

        public sbyte Idcategoria { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<CaoOmbudsman> CaoOmbudsmen { get; set; }
    }
}
