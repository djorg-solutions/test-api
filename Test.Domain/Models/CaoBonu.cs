using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoBonu
    {
        public int BonCategoria { get; set; }
        public int BonInicio { get; set; }
        public int BonFim { get; set; }
        public float? BonValorSem { get; set; }
        public float? BonValorFimsem { get; set; }
    }
}
