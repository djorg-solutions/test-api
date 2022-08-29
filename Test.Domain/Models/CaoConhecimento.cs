using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoConhecimento
    {
        public CaoConhecimento()
        {
            CaoConhecimentosFontes = new HashSet<CaoConhecimentosFonte>();
            CaoPontosConhecimentos = new HashSet<CaoPontosConhecimento>();
        }

        public int Idconhecimento { get; set; }
        public string Assunto { get; set; }
        public string Conhecimento { get; set; }
        public string Url { get; set; }
        public string Tags { get; set; }
        public string Usuario { get; set; }
        public DateTime Datahora { get; set; }

        public virtual CaoUsuario UsuarioNavigation { get; set; }
        public virtual ICollection<CaoConhecimentosFonte> CaoConhecimentosFontes { get; set; }
        public virtual ICollection<CaoPontosConhecimento> CaoPontosConhecimentos { get; set; }
    }
}
