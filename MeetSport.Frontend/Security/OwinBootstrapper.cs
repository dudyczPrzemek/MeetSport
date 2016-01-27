using MeetSport.Backend.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeetSport.Frontend.Security
{
	public class OwinBootstrapper : GoldenEye.Frontend.Security.Web.OwinBoostrapper
	{
        protected override GoldenEye.Backend.Security.DataContext.IUserDataContext<GoldenEye.Backend.Security.Model.User> CreateUserDataContext(Microsoft.AspNet.Identity.Owin.IdentityFactoryOptions<GoldenEye.Backend.Security.DataContext.IUserDataContext<GoldenEye.Backend.Security.Model.User>> options, Microsoft.Owin.IOwinContext context)
        {
            return new SampleContext();
        }
	}
}