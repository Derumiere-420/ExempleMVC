using CrazyBooks.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyBooks.Controllers
{
  public class BookController : Controller
  {
    public IActionResult Index()
    {
      this.ViewBag.MaListe = new List<Book>()
      {
        new Book(){ Id=1, Title= "Cobayes", ISBN= "9782896623921"},
        new Book(){Id=2, Title= "Enlèvement", ISBN= "9782896626151" },
        new Book(){Id=3, Title= "Le chiffreur", ISBN= "9782890747364" },
        new Book(){Id=4, Title= "Les Maudits", ISBN= "9782896628773"}
      };
      return View();
    }

    //GET CREATE
    public IActionResult Create()
    {
      return View();
    }

    //POST CREATE
    [HttpPost]
    public IActionResult Create(Book book)
    {
      if (ModelState.IsValid)
      {
        // Ajouter à la BD
      }

      return this.View(book);
    }
  }
}
