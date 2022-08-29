using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoParticipacaoFuncionario
    {
        public uint CoPartFuncionario { get; set; }
        public float PcParticipacao { get; set; }
        public string CoUsuario { get; set; }
        public byte CoEscritorio { get; set; }
        public DateTime DtReferencia { get; set; }
    }
}
