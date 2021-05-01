using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SelfieAWookies.Core.Selfies.Domain;
using SelfieAWookies.Core.Selfies.Infrastructure.Data;

namespace SelfieAWookie.API.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelfiesController : ControllerBase
    {
        private readonly SelfiesContext _context;
        public SelfiesController(SelfiesContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            // var model = Enumerable.Range(1, 10).Select((item) => new Selfie() {Id = item});
            var model = _context.Selfies.Include(item => item.Wookie)
                .Select(item => new
                {
                    item.Title,
                    item.WookieId,
                    NbSelfiesFromWookie = item.Wookie.Selfies.Count
                })
                .ToList();
            return Ok(model);
        }
    }
}