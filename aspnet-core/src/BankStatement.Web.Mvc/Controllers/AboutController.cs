using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using BankStatement.Controllers;

namespace BankStatement.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : BankStatementControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
