using System.Threading.Tasks;
using BankStatement.Models.TokenAuth;
using BankStatement.Web.Controllers;
using Shouldly;
using Xunit;

namespace BankStatement.Web.Tests.Controllers
{
    public class HomeController_Tests: BankStatementWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}