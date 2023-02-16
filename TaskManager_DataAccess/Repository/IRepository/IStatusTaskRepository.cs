using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_DataAccess.Repository.IRepository
{
    public interface IStatusTaskRepository: IRepository<StatusTask>
    {
        void Update(StatusTask obj);
    }
}
