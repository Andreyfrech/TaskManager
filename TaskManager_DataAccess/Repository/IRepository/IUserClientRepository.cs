using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_Models;

namespace TaskManager_DataAccess.Repository.IRepository
{
    public interface IUserClientRepository: IRepository<UserClient>
    {
        void Update(UserClient obj);
    }
}
