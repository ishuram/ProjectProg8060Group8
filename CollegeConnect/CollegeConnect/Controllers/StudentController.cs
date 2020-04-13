using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CollegeConnect.Models;
using DataModels.Models;
using Library.BusinessLogic;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace CollegeConnect.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        private IConfiguration _configuration;



        public StudentController(IConfiguration Configuration)
        {
            _configuration = Configuration;
        }


        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        
        [HttpPost]
        public IActionResult Index(Student student)
        {

            student.Email = User.Identity.Name;
            student.DateCreated = DateTime.Now;
            student.SType = "P";
            StudentHandler handler = new StudentHandler(_configuration);
            var newcontact = handler.AddStudent(student);
            return View("Sucess");
           // return RedirectToAction("FindOrPostRide");

            
        }
        public IActionResult Sucess()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }
        //[HttpGet]
        //public IActionResult History()
        //{
        //    return View();
        //}
        [HttpPost]
        public IActionResult Search(Student r)
        {

            r.Email = User.Identity.Name;
            r.DateCreated = DateTime.Now;
            r.SType = "S";
          
            if (r.CheckNotEmpty() && r.CheckDestNotEmpty())
            {
                StudentHandler handler = new StudentHandler(_configuration);
                var newcontact = handler.AddStudent(r);
                return RedirectToAction("FindRide", r);
            }
            else
            {
                
                ViewBag.Message="Enter all details in proper format!";
                return View();
            }
          


        }
        public IActionResult FindRide(Student r)
        {
            StudentHandler handler = new StudentHandler(_configuration);
            var contacts = handler.GetAllStudentSearch(r);
            
            return View(contacts);
        }
        public IActionResult AllRides()
        {
            StudentHandler handler = new StudentHandler(_configuration);
            var contacts = handler.GetAllStudent();
            return View(contacts);
        }
        //[HttpPost]
        public IActionResult History(Student r)
        {
            string email= User.Identity.Name;
            StudentHandler handler = new StudentHandler(_configuration);
            var contacts = handler.GetAllStudentHistory(email);
            return View(contacts);
        }
    }
}