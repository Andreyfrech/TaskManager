
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TaskManager_DataAccess.BaseData;

namespace TaskManager_DataAccess
{
    public class Clients: BaseModel
    {
        [Display(Name = "Адрес")]
        public string Addres { get; set; }

        [Display(Name = "ИНН")]
        public decimal INN { get; set; }

        //[Display(Name = "Контактное лицо")]
        //public string ContactPersonId { get; set; }

        [Display(Name = "Номер телефона")]
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        [Display(Name = "Договор")]
        public string ContractNumber { get; set; }

        //[ForeignKey("ContactPersonId")]
        //public virtual IdentityUser User { get; set; }
    }
}
