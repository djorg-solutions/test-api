using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Domain.Models
{
    public partial class CaoDiaryReport
    {
        public int CoDiaryReport { get; set; }
        public TimeSpan? HrGasta { get; set; }
        public int CoAtividade { get; set; }
        public string DsAssunto { get; set; }
        public long CoMovimento { get; set; }
        public ulong? NuOs { get; set; }
        public ulong? CoSistema { get; set; }
    }
}
