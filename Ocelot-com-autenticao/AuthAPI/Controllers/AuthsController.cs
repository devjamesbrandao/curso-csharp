using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthAPI.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AuthAPI.Controllers
{
   [ApiController]
   [Route("api/[controller]")]
   public class AuthsController : ControllerBase
   {
      IConfiguration _configuration;
      public AuthsController(IConfiguration configuration)
      {
         _configuration = configuration;
      }
      public IActionResult Login(string userName, string password)
      {
         TokenHandler._configuration = _configuration;
         return Ok(userName == "gncy" && password == "12345" ? TokenHandler.CreateAccessToken() : new UnauthorizedResult());
      }
   }
}
