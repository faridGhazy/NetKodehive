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

        

        public async Task<bool> Delete(int id)
        {
            await _dbService.DeleteData("DELETE FROM mahasiswa WHERE id=@id", new {id = @id});
            return true;
        }

        public async Task<List<Mahasiswa>> GetAll()
        {
            var result = await _dbService.GetData<Mahasiswa>("Select * From Mahasiswa", new {});
            return result;
        }

        public async Task<bool> Update(Mahasiswa model)
        {
            await _dbService.ModifyData("UPDATE mahasiswa " +
                "SET nama=@nama, alamat=@alamat, usia=@usia, jurusan_id=@jurusan_id " +
                "where id=@id", model);
            return true;
        }
    }
}
