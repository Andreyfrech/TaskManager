﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TaskManager_DataAccess;
using TaskManager_DataAccess.BaseData;

namespace TaskManager_Models
{
    public class TaskHeader: BaseModel
    {
        [Required]
        [Display(Name = "Статус")]
        public int StatusId { get; set; }

        [Required]
        [Display(Name = "Тип")]
        public int TypeId { get; set; }

        [Required]
        [Display(Name = "Постановщик")]
        public string DirectorId { get; set; }

        [Required]
        [Display(Name = "Исполнитель")]
        public string ExecutorId { get; set; }

        [Required]
        [Display(Name = "Клиент")]
        public string ClientId { get; set; }

        [Required]
        [Display(Name = "Планируемая дата завершения")]
        public DateTime PlannedDateComplition { get; set; }

        [ForeignKey("StatusId")]
        public virtual StatusTask Status { get; set; }
        [ForeignKey("TypeId")]
        public virtual TypeTask Type { get; set; }
        [ForeignKey("DirectorId")]
        public virtual IdentityUser Director { get; set; }
        [ForeignKey("ExecutorId")]
        public virtual IdentityUser Executor { get; set; }
        [ForeignKey("ClentId")]
        public virtual IdentityUser Client { get; set; }
    }
}
