﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoEscalaRanking
    {
        public CaoEscalaRanking()
        {
            CaoPontosConhecimentos = new HashSet<CaoPontosConhecimento>();
        }

        public sbyte Idescala { get; set; }
        public sbyte QtdVisual { get; set; }
        public int Pontuacao { get; set; }

        public virtual ICollection<CaoPontosConhecimento> CaoPontosConhecimentos { get; set; }
    }
}
