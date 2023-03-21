using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_DataAccess.Data;
using TaskManager_DataAccess.Repository.IRepository;
using TaskManager_Models;

namespace TaskManager_DataAccess.Repository
{
    public class UserClientRepository : Repository<UserClient>, IUserClientRepository
    {
        private readonly ApplicationDbContext _db;

        public UserClientRepository(ApplicationDbContext db): base(db) 
        {
            _db = db;
        }

        public void Update(UserClient obj)
        {
            _db.Update(obj);
        }
    }
}
