using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Portfolio
{
    public class PortfolioList:ViewComponent
    {
        PortfolioManager portfolioManager=new PortfolioManager(new EfPortfolioDal());

        public IViewComponentResult Invoke()
        {
            var portfolio = portfolioManager.TGetList();
            return View(portfolio);
        }
    }
}
