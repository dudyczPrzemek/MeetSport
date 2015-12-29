using System.Web.Http;
using MeetSport;
using GoldenEye.Frontend.Core.Web.Controllers;
using MeetSport.Shared.Services;
using MeetSport.Shared.DTOs;

namespace MeetSport.Controllers
{
    [Authorize]
    public class TaskController : RestControllerBase<ITaskRestService, TaskDTO>
    {
        public TaskController()
        {
        }

        public TaskController(ITaskRestService service)
            : base(service)
        {
        }
    }
}
