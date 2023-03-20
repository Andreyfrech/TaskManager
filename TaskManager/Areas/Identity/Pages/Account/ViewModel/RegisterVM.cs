
using Microsoft.AspNetCore.Mvc.Rendering;
using TaskManager_DataAccess.Repository.IRepository;

namespace TaskManager.Areas.Identity.Pages.Account.ViewModel
{
    public class RegisterVM
    {
        private readonly IClientsRepository _clientRepo;

        public RegisterVM(IClientsRepository clientRepo)
        {
            _clientRepo = clientRepo;
        }

        public RegisterModel RegisterModel { get; set; }
        public IEnumerable<SelectListItem> OrganizationSelectList 
        {
            get
            {
               return (IEnumerable<SelectListItem>)_clientRepo.GetAllDropdownList();
            }
            set { }
        }
    }
}
