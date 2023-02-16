﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_DataAccess.Repository.IRepository
{
    public interface IClientsRepository: IRepository<Clients>
    {
        void Update(Clients obj);
    }
}
