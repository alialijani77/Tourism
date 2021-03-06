﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataLayer.Context;
using DataLayer.Repositories.Repository;
using DataLayer.Model;

namespace Gardeshgari.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PageGroupsController : Controller
    {
        private IPageGroup pageGroups;

        public PageGroupsController(IPageGroup pageGroups)
        {
            this.pageGroups = pageGroups;
        }

        // GET: Admin/PageGroups
        public async Task<IActionResult> Index()
        {
            return View(pageGroups.Getallpagegroup());
        }

        // GET: Admin/PageGroups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pageGroup = pageGroups.GetByID(id.Value);
            if (pageGroup == null)
            {
                return NotFound();
            }

            return View(pageGroup);
        }

        // GET: Admin/PageGroups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/PageGroups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GroupID,GroupTitle")] PageGroup pageGroup)
        {
            if (ModelState.IsValid)
            {
                pageGroups.Insert(pageGroup);
                pageGroups.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(pageGroup);
        }

        // GET: Admin/PageGroups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pageGroup = pageGroups.GetByID(id.Value);
            if (pageGroup == null)
            {
                return NotFound();
            }
            return View(pageGroup);
        }

        // POST: Admin/PageGroups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GroupID,GroupTitle")] PageGroup pageGroup)
        {
            if (id != pageGroup.GroupID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    pageGroups.Update(pageGroup);
                    pageGroups.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PageGroupExists(pageGroup.GroupID))
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
            return View(pageGroup);
        }

        // GET: Admin/PageGroups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pageGroup = pageGroups.GetByID(id.Value);
            if (pageGroup == null)
            {
                return NotFound();
            }

            return View(pageGroup);
        }

        // POST: Admin/PageGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pageGroup = pageGroups.GetByID(id);
            pageGroups.Delete(pageGroup);
            pageGroups.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool PageGroupExists(int id)
        {
            return pageGroups.IsExists(id);
        }
    }
}
