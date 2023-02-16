
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_DataAccess;

namespace TaskManager_Models
{
    public class UserClient
    {
        [Required]
        [Display(Name = "Сотрудник")]
        public string UserId { get; set; }

        [Required]
        [Display(Name = "Клиент")]
        public int ClientId { get; set; }

        [ForeignKey("UserId")]
        public virtual IdentityUser User { get; set; }
        [ForeignKey("ClientId")]
        public virtual Clients Client { get; set; }
    }
}
