using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

using TaskManager_DataAccess.Data;
using TaskManager_DataAccess.Repository.IRepository;

namespace TaskManager_DataAccess.Repository
{
    public class ClientRepository : Repository<Clients>, IClientsRepository
    {
        private readonly ApplicationDbContext _db;

        public ClientRepository(ApplicationDbContext db): base(db) 
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetAllDropdownList()
        {
            return _db.Clients.Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
        }

        public void Update(Clients obj)
        {
            _db.Update(obj);
        }

        
    }
}
