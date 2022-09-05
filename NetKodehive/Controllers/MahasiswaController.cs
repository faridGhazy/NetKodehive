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
        [HttpGet]
        public async Task<List<Mahasiswa>> GetAll()
        {
            var result = await mahasiswaService.GetAll();
            return result;
        }

        /*[HttpGet("{id:int}")]
        public async Task<ActionResult<Mahasiswa>> GetById(int id)
        {
            var result = await mahasiswaService.GetDataById(id);
            return result;
        }*/

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Mahasiswa>> Delete(int id)
        {
            var result = await mahasiswaService.Delete(id);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] Mahasiswa model)
        {
            var result = await mahasiswaService.Update(model);
            return Ok(result);
        }
    }
    
}
