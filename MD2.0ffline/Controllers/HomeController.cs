using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MD2._0ffline.Models;
using MD2._0ffline.Data;

namespace MD2._0ffline.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public SQLRepository<Note> noteContext;

        public HomeController(ILogger<HomeController> logger, SQLRepository<Note> Note)
        {
            _logger = logger;
            this.noteContext = Note;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Note note)
        {
            if (!ModelState.IsValid)
            {
                return View(note);
            }
            else
            {
                noteContext.Insert(note);
                noteContext.Commit();
                return RedirectToAction("NotedAdded");
            }
        }

        public IActionResult Notes()
        {
            List<Note> notes = noteContext.Collection().OrderByDescending(n => n.CreatedAt).ToList();
            return View(notes);
        }

        public IActionResult NoteAdded()
        {
            return View();
        }

        public IActionResult DeleteNote(string Id)
        {
            Note note = noteContext.Find(Id);
            return View(note);
        }
        [HttpPost]
        public IActionResult DeleteNote(Note note)
        {
            noteContext.Delete(note.Id);
            noteContext.Commit();

            return RedirectToAction("Notes");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
