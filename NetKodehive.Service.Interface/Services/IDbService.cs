﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetKodehive.Service.Interface.Services
{
    public interface IDbService
    {
        Task<int> ModifyData(string command, object param);
    }

}
