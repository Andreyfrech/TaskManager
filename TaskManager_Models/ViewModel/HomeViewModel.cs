using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_DataAccess;

namespace TaskManager_Models.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<TaskHeader> TaskHeaders { get; set; }
        public TaskDetail TaskDetail { get; set; }
        public IEnumerable<HistoryTask> HistoryTasks { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
