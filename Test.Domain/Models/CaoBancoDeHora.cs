using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoBancoDeHora
    {
        public int Id { get; set; }
        public string CoUsuario { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Segundos { get; set; }
        public string Tipo { get; set; }
    }
}
