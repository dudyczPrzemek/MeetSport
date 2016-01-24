using GoldenEye.Frontend.Core.Web.Controllers;
using MeetSport.Shared.Services;
using MeetSport.Shared.DTOs;

namespace MeetSport.Frontend.Controllers
{
    [System.Web.Http.Authorize]
    public class SportsController : RestControllerBase<ISportsRestService, SportsDTO>
    {
        public SportsController() { }

        public SportsController(ISportsRestService service)
            : base(service)
        { 
        }
    }
}