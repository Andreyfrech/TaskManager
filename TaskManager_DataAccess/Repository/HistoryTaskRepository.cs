using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_DataAccess.Data;
using TaskManager_DataAccess.Repository.IRepository;

namespace TaskManager_DataAccess.Repository
{
    public class HistoryTaskRepository : Repository<HistoryTask>, IHistoryTasksRepository
    {
        private readonly ApplicationDbContext _db;

        public HistoryTaskRepository(ApplicationDbContext db): base(db) 
        {
            _db = db;
        }

        public void Update(HistoryTask obj)
        {
            _db.Update(obj);
        }
    }
}
