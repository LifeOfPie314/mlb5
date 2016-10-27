using System;
using System.Data.Entity;
using System.Web.Http;
using Autofac;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Owin;
using Mlb5.App_Start;
using Mlb5.Migrations;
using Mlb5.Security;

[assembly: OwinStartup(typeof(Mlb5.Startup))]

namespace Mlb5
{
    public class Startup
    {
        private IContainer _container;

        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            _container = AutofacConfig.Start();

            ConfigureOAuth(app);


            JsonConfig.Register(config);

            WebApiConfig.Register(config);
            app.UseCors(CorsOptions.AllowAll);
            app.UseWebApi(config);


            Database.SetInitializer(new MigrateDatabaseToLatestVersion<PrototypeContext, Configuration>());
        }

        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),


                Provider = new SimpleAuthorizationServerProvider()
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

        }
    }
}
