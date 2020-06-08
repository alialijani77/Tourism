using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Repositories.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Gardeshgari.Controllers
{
    public class PagesController : Controller
    {
        private IPages pages;

        public PagesController(IPages pages)
        {
            this.pages = pages;
        }
        [Route("Archived")]
        public IActionResult Archived()
        {
            return View(pages.Getallpage());
        }

        [Route("Pages/{id}")]
        public IActionResult Pages(int id)
        {
            var page = pages.GetByID(id);
            if (page != null)
            {
                page.Visit += 1;
                pages.Update(page);
                pages.Save();
            }
            return View(page);
        }
        [Route("Search")]
        public IActionResult Search(string q)
        {
            ViewBag.s = q;
            return View(pages.Search(q));
        }
    }
}
