using Microsoft.AspNet.Mvc;
using SRS.Models;
using SRS.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRS.Controllers {
    public class WordController : Controller {
        SRSContext db;

        public WordController(SRSContext context) {
            db = context;
        }

        public IActionResult Add() {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Word word) {
            return View();
        }

        public IActionResult forms(string text) {
            if (text == null) {
                text = string.Empty;
            }

            var forms = db.Conjugations
                .Where(x => x.tense.Contains(text))
                .Select(x => new {
                    value = x.english,
                    display = x.hangeul
                })
                .ToList();

            return Json(forms);
        }
    }
}
