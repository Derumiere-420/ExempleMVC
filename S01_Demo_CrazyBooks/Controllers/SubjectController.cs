using CrazyBooks.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CrazyBooks.Controllers
{
    public class SubjectController : Controller
    {

        private static List<Subject> MaListe = new List<Subject>()
      {
        new Subject() { Name = "Thriller", Id = 1},
        new Subject() { Name = "Biographie", Id = 2},
        new Subject() { Name = "Drame", Id = 3},
        new Subject() { Name = "Ressources humaines", Id = 4}
    };
        public IActionResult Index()
        {
            List<Subject> MaListeJson = LoadSubjectsFromFile();
            if (MaListeJson.Count > 0)
            {
                ViewBag.MaListe = MaListeJson;
            }
            else 
            {
                ViewBag.MaListe = MaListe;
            }

            return View();
        }

        //GET CREATE
        public IActionResult Create()
        {
            // Ajout d'une information au ViewBag
            //this.ViewBag.MaListe = MaListe;
            return View();
        }

        //POST CREATE
        [HttpPost]
        public IActionResult Create(Subject subject)
        {
            if (ModelState.IsValid)
            {
                MaListe.Add(subject);
                SaveSubjectsToFile();//enregistrer dans un fichier json
                return RedirectToAction("Index");
            }

            return this.View(subject);

        }

        public void SaveSubjectsToFile()
        {
            // Hardcoded path to the bin\Debug directory
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "bin", "Debug", "net6.0", "subjects.json"); // Adjust the path according to your target framework

            var json = JsonSerializer.Serialize(MaListe);
            System.IO.File.WriteAllText(filePath, json);
        }

        public List<Subject> LoadSubjectsFromFile()
        {
            // Hardcoded path to the bin\Debug directory
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "bin", "Debug", "net6.0", "subjects.json");

            if (System.IO.File.Exists(filePath))
            {
                var json = System.IO.File.ReadAllText(filePath);
                MaListe = JsonSerializer.Deserialize<List<Subject>>(json) ?? new List<Subject>();
                
            }
            return MaListe;
        }

    }
}
