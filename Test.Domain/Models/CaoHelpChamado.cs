﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoHelpChamado
    {
        public int CoChamado { get; set; }
        public string DsChamado { get; set; }
        public string DsSolucao { get; set; }
        public sbyte CoStatus { get; set; }
        public int CoMotivo { get; set; }
        public int CoTela { get; set; }
        public int CoAutor { get; set; }
        public int CoFilial { get; set; }
        public long CoSistema { get; set; }
        public DateTime DtChamado { get; set; }
        public DateTime? DtSolucao { get; set; }
    }
}
