using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using TaskManager_DataAccess.Data;
using TaskManager_DataAccess.Repository.IRepository;
using TaskManager_Models;
using TaskManager_Utility;

namespace TaskManager_DataAccess.Repository
{
    public class TaskRepository : Repository<Tasks>, ITaskRepository
    {
        private readonly ApplicationDbContext _db;

        public TaskRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetAllDropdownList(string obj)
        {
            if(obj == WC.StatusTask)
            {
                return _db.StatusTasks.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                });
            }

            if (obj == WC.TypeTask)
            {
                return _db.TypeTasks.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                });
            }
            return null;
        }

        public void Update(TaskHeader obj)
        {
            _db.TaskHeader.Update(obj);
        }

        public void Update(Tasks obj)
        {
            throw new NotImplementedException();
        }
    }
}
