using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoOmbudsman
    {
        public int Id { get; set; }
        public sbyte Idtipo { get; set; }
        public sbyte Idcategoria { get; set; }
        public DateTime Data { get; set; }
        public string Comentario { get; set; }
        public sbyte CoEscritorio { get; set; }

        public virtual CaoCategoriasOmbudsman IdcategoriaNavigation { get; set; }
        public virtual CaoTipoOmbudsman IdtipoNavigation { get; set; }
    }
}
