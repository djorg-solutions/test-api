using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Application.Dto
{
    public class ReportFormDto
    {
        public string[] consultants { get; set; }
        public int reportType { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
