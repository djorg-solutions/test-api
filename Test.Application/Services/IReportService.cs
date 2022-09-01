using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;
using Test.Domain.Models;

namespace Test.Application.Services
{
    public interface IReportService
    {
        IEnumerable<ReportRelatorioResultDto> RelatorioReport(ReportFormDto model);
        ReportGraficaResultDto GraficaReport(ReportFormDto model);
        ReportPizzaResultDto PizzaReport(ReportFormDto model);
    }
}
