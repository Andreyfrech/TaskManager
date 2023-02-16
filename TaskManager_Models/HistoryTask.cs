
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TaskManager_DataAccess.BaseData;
using TaskManager_Models;

namespace TaskManager_DataAccess
{
    public class HistoryTask: BaseModel
    {
        [Display(Name = "Задача")]
        public int TaskId { get; set; }

        [Display(Name = "Дата изменения")]
        public DateTime DateUpdate { get; set; }

        [Display(Name = "Событие")]
        public string Event { get; set; }

        [Display(Name = "Сообщение")]
        public string Message { get; set; }

        [Display(Name = "Пользователь")]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual IdentityUser User { get; set; }
        [ForeignKey("TaskId")]
        public virtual TaskHeader TaskHeader { get; set; }
    }
}
