using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SelfieAWookie.API.UI.Applications.DTOs;
using SelfieAWookies.Core.Selfies.Domain;
using SelfieAWookies.Core.Selfies.Infrastructure.Data;

namespace SelfieAWookie.API.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelfiesController : ControllerBase
    {
        private readonly ISelfieRepository _repository;
        public SelfiesController(ISelfieRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            // var model = Enumerable.Range(1, 10).Select((item) => new Selfie() {Id = item});
            var selfieList = _repository.GetAll();
            
            var model = selfieList
                .Select(item => new SelfieResumeDto()
                {
                    Title = item.Title,
                    WookieId = item.WookieId,
                    NbSelfiesFromWookie = (item.Wookie?.Selfies?.Count).GetValueOrDefault(0)
                })
                .ToList();
            
            return Ok(model);
        }
    }
}