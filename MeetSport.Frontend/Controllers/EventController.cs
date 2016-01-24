using GoldenEye.Backend.Security.Service;
using GoldenEye.Frontend.Core.Web.Controllers;
using MeetSport.Shared.DTOs;
using MeetSport.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MeetSport.Frontend.Controllers
{
    [System.Web.Http.Authorize]
    public class EventController : RestControllerBase<IEventRestService, EventDTO>
    {
        public EventController()
        {
        }

        public EventController(IEventRestService service)
            : base(service)
        {
        }

        public override Task<IHttpActionResult> Put(EventDTO model)
        {
            model.FounderName = User.Identity.Name;

            Service.Put(model);

            return null;
        }

        public IQueryable<EventDTO> Get(string cityName)
        {
            var userName = User.Identity.Name;

            var result = Service.GetNewEvents(cityName, userName);
            return result.AsQueryable();
        }

        public IQueryable<EventDTO> Get(string sportName, string cityName, DateTime date)
        {
            var userName = User.Identity.Name;

            var result = Service.GetFilteredEvents(cityName, sportName, date, userName);
            return result.AsQueryable();
        }

        public IQueryable<EventDTO> Get(int id, bool myMethod)
        {
            var result = Service.GetById(id);

            return result.AsQueryable();
        }

        public IQueryable<EventDTO> Get(string userName, bool myMethod)
        {
            var result = Service.GetForUser(userName);

            return result.AsQueryable();
        }

    }
}