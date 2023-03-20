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
    public class ApplicationUser: IdentityUser
    {
        [Display(Name = "ФИО")]
        public string FullName { get; set; }
        [Display(Name = "Адресс")]
        public string StreetAddress { get; set; }
        [Display(Name = "Город")]
        public string City { get; set; }
        [Display(Name = "Организация")]
        public int OrganizationId { get; set; }

        [ForeignKey("OrganizationId")]
        public virtual Clients Clients { get; set; }
        
    }
}
