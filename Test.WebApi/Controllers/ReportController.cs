using Test.Domain;
using Test.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using Test.Application.Services;
using Test.Domain.Models;
using Test.Application.Dto;
using System.Linq.Expressions;
using Test.Application.enums;

namespace Test.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        /// <summary>
        /// Report Relatorio
        /// </summary>
        [HttpPost]
        [Route("relatorio")]
        public IEnumerable<ReportRelatorioResultDto> PostRelatorio([FromBody] ReportFormDto model)
        {
            return _reportService.RelatorioReport(model);

        }

        /// <summary>
        /// Report Grafica
        /// </summary>
        [HttpPost]
        [Route("grafica")]
        public ReportGraficaResultDto PostGrafica([FromBody] ReportFormDto model)
        {
            return _reportService.GraficaReport(model);

        }

        /// <summary>
        /// Report Pizza
        /// </summary>
        [HttpPost]
        [Route("pizza")]
        public ReportPizzaResultDto PostPizza([FromBody] ReportFormDto model)
        {
            return _reportService.PizzaReport(model);

        }

    }
}
