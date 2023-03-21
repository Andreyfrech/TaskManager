using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_Models
{
    public class TaskDetail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int TaskHeaderId { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Дата создания")]
        public DateTime DateCreate { get; set; }

        [Display(Name = "Дата перевода на тещий статус")]
        public DateTime DateUpdate { get; set; }

        [Required]
        [Display(Name = "Планируемая дата завершения")]
        public DateTime PlannedDateComplition { get; set; }

        [Display(Name = "Дата завершения")]
        public DateTime DateComplition { get; set; }

        [Required]
        [Display(Name = "Выделенное время")]
        public DateTime AllottedTimeWork { get; set; }

        [Display(Name = "Затраченное время")]
        public DateTime ActualTimeWork { get; set; }

        [ForeignKey("TaskHeaderId")]
        public virtual TaskHeader TaskHeader { get; set; }
    }
}
