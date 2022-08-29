using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoConhecimentosFonte
    {
        public int Idfonte { get; set; }
        public int Idconhecimento { get; set; }
        public DateTime Datahora { get; set; }
        public string Arquivo { get; set; }
        public string Caminho { get; set; }

        public virtual CaoConhecimento IdconhecimentoNavigation { get; set; }
    }
}
