using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetKodehive.Model.Entities
{
    public class Mahasiswa
    {
        public int id { get; set; }
        public string nama { get; set; }
        public string alamat { get; set; }
        public int usia { get; set; }
        public int jurusan_id { get; set; }

    }
}
