using NetKodehive.Data.Interface.Repositories;
using NetKodehive.Model.Entities;
using NetKodehive.Service.Interface.Services;
using NetKodehive.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetKodehive.Data.Repositories
{
    public class MahasiswaRepository : IMahasiswaRepository
    {
        private readonly IDbService _dbService;

        public MahasiswaRepository(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<bool> Create(Mahasiswa model)
        {
            await _dbService.ModifyData("INSERT INTO mahasiswa" +
                "(id, nama, alamat, usia, jurusan_id)"+
                "values"+
                "(@id, @nama, @alamat, @usia, @jurusan_id)", model);
            return true;
        }

    }
}
