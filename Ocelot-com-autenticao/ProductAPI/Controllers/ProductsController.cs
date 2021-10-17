using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProductAPI.Controllers
{
   [ApiController]
   [Route("api/[controller]")]
   [Authorize]
   public class ProductsController : ControllerBase
   {
      public IActionResult Get()
      {
         return Ok(new List<string> {
           "Telefon", "Terlik", "Kalem", "Kağıt", "Ampul", "Kağıt"
         });
      }
   }
}
