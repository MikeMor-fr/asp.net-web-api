using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SelfieAWookie.API.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelfiesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Selfie> Get()
        {
            return Enumerable.Range(1, 10).Select((item) => new Selfie() {Id = item});
        }
    }
}