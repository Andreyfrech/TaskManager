using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskManager.Models;
using TaskManager_DataAccess.Repository.IRepository;
using TaskManager_Models.ViewModel;

namespace TaskManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITaskHeaderRepository _taskHRepo;
        private readonly IApplicationUserRepository _applicationUserRepo;
        HomeViewModel homeVM = new HomeViewModel();
        public HomeController(ILogger<HomeController> logger, ITaskHeaderRepository taskHrepo, IApplicationUserRepository applicationUserRepo)
        {
            _logger = logger;
            _taskHRepo = taskHrepo;
            _applicationUserRepo = applicationUserRepo;
        }

        public IActionResult Index()
        {

             homeVM = new HomeViewModel()
            {
                //ApplicationUser = _applicationUserRepo.FirstOrDefault(u => u.Id == Task)
                TaskHeaders = _taskHRepo.GetAll(includeProperties: "Client,Director,Executor,Status,Type")
            };
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetInquiryList()
        {
            return Json(new { data = homeVM });
        }
        #endregion
    }
}