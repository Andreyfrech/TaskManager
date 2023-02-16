using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TaskManager_DataAccess.Repository.IRepository
{
    public interface ITaskRepository: IRepository<Tasks>
    {
        IEnumerable<SelectListItem> GetAllDropdownList(string obj);
        void Update(Tasks obj);
    }
}
