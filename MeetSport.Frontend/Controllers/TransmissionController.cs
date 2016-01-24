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
    public class TransmissionController : RestControllerBase<ITransmissionRestService, TransmissionDTO>
    {
        public TransmissionController() { }
        public TransmissionController(ITransmissionRestService service)
            :base(service)
        {
        }

        public override IQueryable<TransmissionDTO> Get()
        {
            var result = Service.Get();

            return result;
        }

        public IQueryable<TransmissionDTO> Get(string userName)
        {
            return null;
        }

        public override Task<IHttpActionResult> Put(TransmissionDTO model)
        {
            model.OwnerName = User.Identity.Name;
            model.EndDate = DateTime.Today;

            Service.Put(model);

            return null;
        }
    }
}