using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CostumerAPI.Controllers
{
   [ApiController]
   [Route("api/[controller]")]
   public class CustomersController : ControllerBase
   {
      public IActionResult Get()
      {
         return Ok(new List<string> {
            "Hilmi", "Hüseyin", "Rıfkı", "Necati", "Şuayip", "Muallim", "Muiddin"
         });
      }
   }
}
