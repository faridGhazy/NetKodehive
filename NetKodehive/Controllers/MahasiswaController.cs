using Microsoft.AspNetCore.Mvc;
using NetKodehive.Model.Entities;
using NetKodehive.Service.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetKodehive.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : Controller
    {
        private readonly IMahasiswaService mahasiswaService;

        public MahasiswaController(IMahasiswaService mahasiswaService)
        {
            this.mahasiswaService = mahasiswaService;
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Mahasiswa model)
        {
            var result = await mahasiswaService.Create(model);
            return Ok(result);
        }

        //Get
    }
    
}
