using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TaskManager_DataAccess.BaseData;

namespace TaskManager_DataAccess
{
    public class TypeTask: BaseModel
    {
        [Display(Name = "Приоритет")]
        public string Priority { get; set; }
    }
}
