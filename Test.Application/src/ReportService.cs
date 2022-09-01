using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;
using Test.Application.Services;
using Test.Domain.Models;
using Test.Domain.Repository;

namespace Test.Application.src
{
    public class ReportService : IReportService
    {
        private readonly IUnitOfWork _uow;
        public ReportService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public IEnumerable<ReportRelatorioResultDto> RelatorioReport(ReportFormDto model)
        {
            List<ReportRelatorioResultDto> list = new List<ReportRelatorioResultDto>();
            foreach (var item in model.consultants)
            {
                CaoUsuario user = _uow.UsuarioRepository.Queryable().Where(d => d.NoUsuario == item).First();
               
                ReportRelatorioResultDto consultant = new ReportRelatorioResultDto();
                consultant.consultant = user.NoUsuario;

                DateTime date = model.startDate;
                while(date <= model.endDate)
                {
                    ProfitDto profit = new ProfitDto();
                    profit.period = getPeriod(date.Month, date.Year);
                    var query = from f in _uow.FacturaRepository.Queryable()
                                join os in _uow.OSRepository.Queryable()
                                on f.CoOs equals os.CoOs
                                where os.CoUsuario == user.CoUsuario && f.DataEmissao.Month == date.Month && f.DataEmissao.Year == date.Year select f;

                    profit.receitaLiquida = query.Count() - query.Sum(d => d.TotalImpInc);
                    profit.custoFixo = _uow.SalarioRepository.Queryable().Where(d => d.CoUsuario == user.CoUsuario).First().BrutSalario;


                    date.AddMonths(1);
                }
            }
            return new List<ReportRelatorioResultDto>();
        }

        public ReportGraficaResultDto GraficaReport(ReportFormDto model)
        {
            return new ReportGraficaResultDto();
        }

        public ReportPizzaResultDto PizzaReport(ReportFormDto model)
        {
            return new ReportPizzaResultDto();
        }

        private string getPeriod(int month, int year)
        {
            string result = "";
            switch (month)
            {
                case 1:
                    result = "Janeiro de "+ year;
                    break;
                case 2:
                    result = "Fevereiro de " + year;
                    break;
                case 3:
                    result = "Março de " + year;
                    break;
                case 4:
                    result = "Abril de " + year;
                    break;
                case 5:
                    result = "Maio de" + year;
                    break;
                case 6:
                    result = "Junho de" + year;
                    break;
                case 7:
                    result = "Julho de" + year;
                    break;
                case 8:
                    result = "Agosto de" + year;
                    break;
                case 9:
                    result = "Setembro de" + year;
                    break;
                case 10:
                    result = "Outubro de" + year;
                    break;
                case 11:
                    result = "Novembro de" + year;
                    break;
                case 12:
                    result = "Dezembro de" + year;
                    break;
                default:
                    break;
            }

            return result;
        }

    }
}
