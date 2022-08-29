using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoConhecimentoUsuario
    {
        public string CoUsuario { get; set; }
        public uint CoConhecimento { get; set; }
        public uint? NvConhecimento { get; set; }
        public byte? IsCertificado { get; set; }
    }
}
