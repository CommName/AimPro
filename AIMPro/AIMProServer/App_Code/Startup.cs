using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Data.Entity;

[assembly: OwinStartup(typeof(Startup))]

public class Startup
{
    public void Configuration(IAppBuilder app)
    {
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        Database.SetInitializer(new DropCreateDatabaseIfModelChanges<UserContext>());
    }
}
