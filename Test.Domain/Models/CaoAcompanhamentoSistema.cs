﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoAcompanhamentoSistema
    {
        public uint CoAcompanhamento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public long? CoSistema { get; set; }
        public string Status { get; set; }
    }
}
