using Microsoft.AspNetCore.Mvc;
using MvcCoreApp.Data;
using MvcCoreApp.Models;
using System.Diagnostics;

namespace MvcCoreApp.Controllers
{
    public class HomeController : Controller
    {
   
        private readonly ApplicationDBContext _db;
        public HomeController(ApplicationDBContext db)
        {
            _db = db;
        }

       

        public IActionResult Index()
        {
            IEnumerable<ChangeRequest> objCatList = _db.ChangeRequests;
            return View(objCatList);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Create()
        {

            return View();
        }

        //POST
        [HttpPost]
      
        public IActionResult Create(ChangeRequest obj)
        {
            obj.Status = ApprovalStatus.Pending;
            _db.ChangeRequests.Add(obj);
            _db.SaveChanges();
            Console.Write("Test");
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}