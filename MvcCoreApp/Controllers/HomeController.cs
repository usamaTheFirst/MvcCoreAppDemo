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
            objCatList.OrderBy(o => o.DateCreated);
            
            return View(objCatList);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        //GET
        public IActionResult Create()
        {

            return View();
        }

        //POST
        [HttpPost]
      
        public IActionResult Create(ChangeRequest obj , int status)
        {
            if(ModelState.IsValid)
            {
                obj.Status = ApprovalStatus.Pending;
                if(status == 0)
                {
                    obj.SubmissionStatus = SubmissionStatus.Draft;
                }
                else
                {
                    obj.SubmissionStatus = SubmissionStatus.Submitted;

                }
                _db.ChangeRequests.Add(obj);
                _db.SaveChanges();
                Console.Write("Test");
                return RedirectToAction("Index");
            }
            return View();
        }
        //GET
        public IActionResult View(int? id)
        {


            if (id == null || id == 0)
            {
                return NotFound();
            }
            var ChangeRequestFromDb = _db.ChangeRequests.Find(id);
            if (ChangeRequestFromDb == null)
            {
                return NotFound();
            }
            return View(ChangeRequestFromDb);
        }


        //GET
        public IActionResult Edit(int? id)
        {


            if (id == null || id == 0)
            {
                return NotFound();
            }
            var ChangeRequestFromDb = _db.ChangeRequests.Find(id);
            if (ChangeRequestFromDb == null)
            {
                return NotFound();
            }
            return View(ChangeRequestFromDb);
        }

        //POST
        [HttpPost]

        public IActionResult Edit(ChangeRequest obj)
        {
            if (ModelState.IsValid)

            {
                obj.SubmissionStatus = SubmissionStatus.Submitted;
                _db.ChangeRequests.Update(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}