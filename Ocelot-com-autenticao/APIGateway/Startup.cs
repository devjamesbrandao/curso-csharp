using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace APIGateway
{
   public class Startup
   {
      public Startup(IConfiguration configuration)
      {
         _configuration = configuration;
      }
      public IConfiguration _configuration { get; }

      public void ConfigureServices(IServiceCollection services)
      {
         SymmetricSecurityKey signInKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Security"]));

         string authenticationProviderKey = "TestKey";
         services.AddAuthentication()
             .AddJwtBearer(authenticationProviderKey, options =>
             {
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                   ValidateIssuerSigningKey = true,
                   IssuerSigningKey = signInKey,
                   ValidateIssuer = true,
                   ValidIssuer = _configuration["JWT:Issuer"],
                   ValidateAudience = true,
                   ValidAudience = _configuration["JWT:Audience"],
                   ValidateLifetime = true,
                   ClockSkew = TimeSpan.Zero,
                   RequireExpirationTime = true
                };
             });
         services.AddOcelot();
         services.AddControllers();
      }

      public async void Configure(IApplicationBuilder app, IWebHostEnvironment env)
      {
         if (env.IsDevelopment())
         {
            app.UseDeveloperExceptionPage();
         }

         app.UseHttpsRedirection();


         app.UseRouting();

         app.UseAuthentication();
         app.UseAuthorization();
         await app.UseOcelot();

         app.UseEndpoints(endpoints =>
         {
            endpoints.MapControllers();
         });
      }
   }
}
