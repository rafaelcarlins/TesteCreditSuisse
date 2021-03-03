using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteCreditSuisse.Interface;
using TesteCreditSuisse.Model;

namespace TesteCreditSuisse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PorfolioController : ControllerBase
    {
        private readonly ITrade _trade;

        public PorfolioController(ITrade trade)
        {
            _trade = trade;

        }

        [Route("AddPorfolio")]
        [HttpPost]
        public bool AddPortfolio(IEnumerable<Trade> trades)
        {
            Portfolio portfolio = new Portfolio();
            portfolio.portfolio = new List<Trade>();

            foreach (var item in trades)
            {
                portfolio.portfolio.Add (item);
            }
            _trade.addPortfolio(portfolio.portfolio);
            
            return true;
        }

    }
}
