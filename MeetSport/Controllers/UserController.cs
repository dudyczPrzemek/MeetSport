using System.Web.Http;
using GoldenEye.Backend.Security.Service;
using GoldenEye.Frontend.Security.Web.Controllers;

namespace MeetSport.Controllers
{
    [Authorize]
    public class UserController : UserControllerBase
    {
        public UserController(IUserRestService service) : base(service)
        {
        }
    }
}