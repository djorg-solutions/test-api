using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Application.Dto
{
    public class ProfitDto
    {
        public string period { get; set; }
        public float receitaLiquida { get; set; }
        public float custoFixo { get; set; }
        public float commissao { get; set; }
        public float lucro { get; set; }
    }
}
