using System.Web.Http;
using GoldenEye.Frontend.Security.Web.Controllers;

namespace MeetSport.Frontend.Controllers
{
    [Authorize]
    [RoutePrefix("api/Account")]
    public class AccountController : AccountControllerBase
    {
    }
}