using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using NearEarthObjectTracker.Models;
using Owin;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

[assembly: OwinStartupAttribute(typeof(NearEarthObjectTracker.Startup))]
namespace NearEarthObjectTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            
        }
    }
}
