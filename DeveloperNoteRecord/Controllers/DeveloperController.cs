using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeveloperNoteRecord.Data;
using DeveloperNoteRecord.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DeveloperNoteRecord.Controllers
{
    public class DeveloperController : Controller
    {
        // GET: /<controller>/
        private DeveloperDbContext _context;
        public DeveloperController(DeveloperDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Developer> developers = _context.Developer.ToList();
            return View(developers);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Developer developer)
        {
            _context.Developer.Add(developer);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}