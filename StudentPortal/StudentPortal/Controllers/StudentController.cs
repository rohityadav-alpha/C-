using Microsoft.AspNetCore.Mvc;
using StudentPortal.Data;
using StudentPortal.Models;
//using System.Collections.Generic;
//using System.Xml.Linq;

namespace StudentPortal.Controllers
{
    public class StudentController : Controller
    {

        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index() 
        {
            List<StudentModel> std = _context.students.ToList();
            
            return View(std);
        }
    }
}
