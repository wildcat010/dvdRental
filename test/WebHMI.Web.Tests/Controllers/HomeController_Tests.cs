using System.Threading.Tasks;
using WebHMI.Models.TokenAuth;
using WebHMI.Web.Controllers;
using Shouldly;
using Xunit;

namespace WebHMI.Web.Tests.Controllers
{
    public class HomeController_Tests: WebHMIWebTestBase
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

