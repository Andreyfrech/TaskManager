using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_DataAccess.Data;
using TaskManager_DataAccess.Repository.IRepository;

namespace TaskManager_DataAccess.Repository
{
    public class TypeTaskRepository : Repository<TypeTask>, ITypeTaskRepository
    {
        private readonly ApplicationDbContext _db;

        public TypeTaskRepository(ApplicationDbContext db): base(db) 
        {
            _db = db;
        }

        public void Update(TypeTask obj)
        {
            _db.Update(obj);
        }
    }
}
