using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using BankStatement.Controllers;

namespace BankStatement.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : BankStatementControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
