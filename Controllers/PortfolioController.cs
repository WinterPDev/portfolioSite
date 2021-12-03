using Microsoft.AspNetCore.Mvc;

namespace portfolioSite.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "This is my Index!";
        }

        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my Contact!";
        }

        [HttpGet("portfolio")]
        public string Portfolio()
        {
            return "This is my Portfolio!";
        }
    }



}