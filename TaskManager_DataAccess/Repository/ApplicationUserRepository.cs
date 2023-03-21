using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

using TaskManager_DataAccess.Data;
using TaskManager_DataAccess.Repository.IRepository;
using TaskManager_Models;

namespace TaskManager_DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db): base(db) 
        {
            _db = db;
        }

        //public IEnumerable<SelectListItem> GetAllDropdownList()
        //{
        //    return _db.Clients.Select(i => new SelectListItem
        //    {
        //        Text = i.Name,
        //        Value = i.Id.ToString()
        //    });
        //}

        public void Update(ApplicationUser obj)
        {
            _db.Update(obj);
        }

        
    }
}
