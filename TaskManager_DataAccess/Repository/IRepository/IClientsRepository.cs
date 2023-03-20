using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TaskManager_DataAccess.Repository.IRepository
{
    public interface IClientsRepository: IRepository<Clients>
    {
        IEnumerable<SelectListItem> GetAllDropdownList();
        void Update(Clients obj);
    }
}
