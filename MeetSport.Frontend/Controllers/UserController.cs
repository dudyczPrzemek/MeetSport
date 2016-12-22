using System.Web.Http;
using GoldenEye.Backend.Security.Service;
using GoldenEye.Frontend.Security.Web.Controllers;
using MeetSport.Backend.Context;
using GoldenEye.Shared.Core.DTOs;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using GoldenEye.Backend.Security.Repositories;
using GoldenEye.Backend.Core.Context;
using System.Linq;

namespace MeetSport.Frontend.Controllers
{
    [Authorize]
    public class UserController : UserControllerBase
    {
        IConnectionProvider _p;
        public UserController(IConnectionProvider p) : base(new UserRestService(new UserRepository(new SampleContext(p))))
        {
            _p = p;
        }

        public override System.Linq.IQueryable<GoldenEye.Shared.Core.DTOs.UserDTO> Get()
        {
            using (var db = new SampleContext(_p))
            {
                var list = db.Users.Select(el => new UserDTO() { Id = el.Id, Email = el.Email, FirstName = el.FirstName, LastName = el.LastName, UserName = el.UserName }).ToList();
                return list.AsQueryable();
            }
        }
    }
}