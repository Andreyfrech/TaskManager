using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_DataAccess.Data;
using TaskManager_DataAccess.Repository.IRepository;

namespace TaskManager_DataAccess.Repository
{
    public class StatusTaskRepoSitory : Repository<StatusTask>, IStatusTaskRepository
    {
        private readonly ApplicationDbContext _db;

        public StatusTaskRepoSitory(ApplicationDbContext db): base(db) 
        {
            _db = db;
        }

        public void Update(StatusTask obj)
        {
           _db.Update(obj);
        }
    }
}
