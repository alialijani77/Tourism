using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataLayer.Context;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using System.IO;
using DataLayer.Repositories.Repository;
using DataLayer.Model;

namespace Gardeshgari.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PagesController : Controller
    {
        private IPages pagess;
        private IPageGroup pageGroup;

        public PagesController(IPages pagess, IPageGroup pageGroup)
        {
            this.pagess = pagess;
            this.pageGroup = pageGroup;
        }

        // GET: Admin/Pages
        public async Task<IActionResult> Index()
        {
            var gardeshgariDbContext = pagess.Getallpage();
            return View(gardeshgariDbContext);
        }

        // GET: Admin/Pages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pages = pagess.GetByID(id.Value);
            if (pages == null)
            {
                return NotFound();
            }

            return View(pages);
        }

        // GET: Admin/Pages/Create
        public IActionResult Create()
        {
            ViewData["GroupID"] = new SelectList(pageGroup.Getallpagegroup(), "GroupID", "GroupTitle");
            return View();
        }

        // POST: Admin/Pages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PageID,GroupID,PageText,PageDescription,Title,Tags,Visit,ImageName,CreateTime,ShowSlider")] Pages pages, IFormFile IMGup)
        {
            if (ModelState.IsValid)
            {
                pages.Visit = 0;
                pages.CreateTime = DateTime.Now;
                if (IMGup != null)
                {
                    pages.ImageName = Guid.NewGuid().ToString() + Path.GetExtension(IMGup.FileName);
                    string pathname = Path.Combine(
                        Directory.GetCurrentDirectory(), "wwwroot/ImagesFolder", pages.ImageName
                        );
                    using (var stream = new FileStream(pathname, FileMode.Create))
                    {
                        await IMGup.CopyToAsync(stream);
                    }
                }
                pagess.Insert(pages);
                pagess.Save();
                return RedirectToAction(nameof(Index));

            }
            ViewData["GroupID"] = new SelectList(pageGroup.Getallpagegroup(), "GroupID", "GroupTitle", pages.GroupID);
            return View(pages);
        }

        // GET: Admin/Pages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pages = pagess.GetByID(id.Value);
            if (pages == null)
            {
                return NotFound();
            }
            ViewData["GroupID"] = new SelectList(pageGroup.Getallpagegroup(), "GroupID", "GroupTitle", pages.GroupID);
            return View(pages);
        }

        // POST: Admin/Pages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PageID,GroupID,PageText,PageDescription,Title,Tags,Visit,ImageName,CreateTime,ShowSlider")] Pages pages, IFormFile IMGup)
        {
            if (id != pages.PageID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (IMGup != null)
                    {
                        if (pages.ImageName == null)
                        {
                            pages.ImageName = Guid.NewGuid().ToString() + Path.GetExtension(IMGup.FileName);
                        }
                        string pathname = Path.Combine(
                            Directory.GetCurrentDirectory(), "wwwroot/ImagesFolder", pages.ImageName
                            );
                        using (var stream = new FileStream(pathname, FileMode.Create))
                        {
                            await IMGup.CopyToAsync(stream);
                        }
                    }
                    pagess.Update(pages);
                    pagess.Save();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PagesExists(pages.PageID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["GroupID"] = new SelectList(pageGroup.Getallpagegroup(), "GroupID", "GroupTitle", pages.GroupID);
            return View(pages);
        }

        // GET: Admin/Pages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pages = pagess.GetByID(id.Value);
            if (pages == null)
            {
                return NotFound();
            }

            return View(pages);
        }

        // POST: Admin/Pages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pages = pagess.GetByID(id);
            pagess.Delete(pages);
            pagess.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool PagesExists(int id)
        {
            return pagess.IsExists(id);
        }
    }
}
