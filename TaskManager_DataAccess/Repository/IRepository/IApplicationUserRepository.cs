using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using TaskManager_Models;

namespace TaskManager_DataAccess.Repository.IRepository
{
    public interface IApplicationUserRepository: IRepository<ApplicationUser>
    {
       // IEnumerable<SelectListItem> GetAllDropdownList();
        void Update(ApplicationUser obj);
    }
}
