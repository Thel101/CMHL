using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeveloperNoteRecord.Data;
using DeveloperNoteRecord.Models;
using DeveloperNoteRecord.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DeveloperNoteRecord.Controllers
{
    public class NoteController : Controller
    {
        // GET: /<controller>/
        private readonly DeveloperDbContext _context;
        public NoteController(DeveloperDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Notes> notes= _context.Notes.Include(a=> a.Developer).ToList();
            return View(notes);
        }
        [HttpGet]
        public IActionResult Create()
        {
            NoteDetailViewModel ndvm = new NoteDetailViewModel() { Developers = _context.Developer.ToList()};
            return View(ndvm);
        }
        [HttpPost]
        public IActionResult Create(Notes obj)
        {
            _context.Notes.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}

