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
    public class SkillSetController : Controller
    {
        // GET: /<controller>/
        private readonly DeveloperDbContext _context;
        public SkillSetController(DeveloperDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.SkillSet.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SkillSet skillSet)
        {
            _context.SkillSet.Add(skillSet);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

