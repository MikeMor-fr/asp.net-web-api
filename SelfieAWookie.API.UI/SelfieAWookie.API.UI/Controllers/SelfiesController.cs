using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfieAWookies.Core.Selfies.Domain;

namespace SelfieAWookie.API.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelfiesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var model = Enumerable.Range(1, 10).Select((item) => new Selfie() {Id = item});
            return Ok(model);
        }
    }
}