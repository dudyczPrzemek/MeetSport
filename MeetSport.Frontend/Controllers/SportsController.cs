using System;
using System.Collections.Generic;
using GoldenEye.Frontend.Core.Web.Controllers;
using System.Linq;
using System.Web;
using System.Web.Http;
using MeetSport.Shared.Services;
using MeetSport.Shared.DTOs;
using System.Web.Mvc;

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

        public override IQueryable<SportsDTO> Get()
        {
            var result = Service.Get();

            return result.AsQueryable();
        }
    }
}