using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.Owin.Security.OAuth;
using Mlb5.Models;

namespace Mlb5.Security
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {

            if (context.UserName == "undefined")
                context.SetError("invalid_grant", "The user name or password is incorrect.");

            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            User user;

            using (var db = new PrototypeContext())
            {
                // if user not found then add user
                user = await db.Users.SingleOrDefaultAsync(x => x.Username == context.UserName);

                if (user == null)
                {
                    user = new User() { Username = context.UserName };
                    db.Users.Add(user);
                    db.SaveChanges();
                }
            }

            //using (AuthRepository _repo = new AuthRepository())
            //{
            //    IdentityUser user = await _repo.FindUser(context.UserName, context.Password);

            //    if (user == null)
            //    {
            //        context.SetError("invalid_grant", "The user name or password is incorrect.");
            //        return;
            //    }
            //}

            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim("userId", user.Id.ToString()));
            identity.AddClaim(new Claim("username", user.Username));
            identity.AddClaim(new Claim("role", "user"));

            context.Validated(identity);

        }
    }
}