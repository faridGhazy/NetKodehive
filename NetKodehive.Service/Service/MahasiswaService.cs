using NetKodehive.Data.Interface.Repositories;
using NetKodehive.Model.Entities;
using NetKodehive.Service.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetKodehive.Service.Service
{
    class MahasiswaService : IMahasiswaService
    {
        private readonly IMahasiswaRepository mahasiswaRepository;

        public MahasiswaService(IMahasiswaRepository mahasiswaRepository)
        {
            this.mahasiswaRepository = mahasiswaRepository;
        }

        public async Task<bool> Create(Mahasiswa mahasiswa)
        {
            var result = await mahasiswaRepository.Create(mahasiswa);
            return true;
        }

        /*public async Task<bool> Delete(Mahasiswa mahasiswa)
        {
            var result = await mahasiswaRepository.Delete(mahasiswa);
            return true;
        }*/

        public async Task<bool> Delete(int id)
        {
            var result = await mahasiswaRepository.Delete(id);
            return true;
        }

        public async Task<List<Mahasiswa>> GetAll()
        {
            var result = await mahasiswaRepository.GetAll();
            return result;
        }

        public async Task<bool> Update(Mahasiswa mahasiswa)
        {
            var result = await mahasiswaRepository.Update(mahasiswa);
            return true;
        }
    }
}
