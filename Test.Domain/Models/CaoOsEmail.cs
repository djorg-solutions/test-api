using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoOsEmail
    {
        public int CoEmail { get; set; }
        public int? CoOs { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public int CoCliente { get; set; }
        public int Ativo { get; set; }
        public string Ddd { get; set; }
        public string Tel { get; set; }
        public string Cargo { get; set; }
    }
}
