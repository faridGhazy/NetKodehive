using NetKodehive.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetKodehive.Service.Interface.Services
{
    public interface IMahasiswaService
    {
        public Task<bool> Create(Mahasiswa mahasiswa);

    }
}
