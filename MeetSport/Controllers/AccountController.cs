using System.Web.Http;
using GoldenEye.Frontend.Security.Web.Controllers;

namespace MeetSport.Controllers
{
    [Authorize]
    [RoutePrefix("api/Account")]
    public class AccountController : AccountControllerBase
    {
    }
}