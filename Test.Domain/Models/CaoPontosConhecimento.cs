using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoPontosConhecimento
    {
        public int Idpontos { get; set; }
        public sbyte Pontuacao { get; set; }
        public string CoCoordenador { get; set; }
        public int Idconhecimento { get; set; }

        public virtual CaoUsuario CoCoordenadorNavigation { get; set; }
        public virtual CaoConhecimento IdconhecimentoNavigation { get; set; }
        public virtual CaoEscalaRanking PontuacaoNavigation { get; set; }
    }
}
