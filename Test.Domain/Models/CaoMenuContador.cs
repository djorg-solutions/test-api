using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoMenuContador
    {
        public string CoUsuario { get; set; }
        public byte CoMenu { get; set; }
        public sbyte NuPontos { get; set; }
        public byte InProcessado { get; set; }
    }
}
