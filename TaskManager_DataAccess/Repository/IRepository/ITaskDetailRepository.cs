using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using TaskManager_Models;

namespace TaskManager_DataAccess.Repository.IRepository
{
    public interface ITaskDetailRepository: IRepository<TaskDetail>
    {
        IEnumerable<SelectListItem> GetAllDropdownList(string obj);
        void Update(TaskDetail obj);
    }
}
