using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_DataAccess.Repository.IRepository
{
    public interface ITypeTaskRepository: IRepository<TypeTask>
    {
        void Update(TypeTask obj);
    }
}
