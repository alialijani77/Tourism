using DataLayer.Context;
using DataLayer.Model;
using DataLayer.Repositories.Repository;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataLayer.Repositories.Services
{
    public class PageRepository : IPages
    {
        private GardeshgariDbContext db;

        public PageRepository(GardeshgariDbContext context)
        {
            this.db = context;
        }
        public void Delete(Pages page)
        {
            db.Entry(page).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        }

        public void Delete(int id)
        {
            var fordelete = GetByID(id);
            Delete(fordelete);
        }

        public IEnumerable<Pages> Getallpage()
        {
            return db.pages.ToList();
        }

        public Pages GetByID(int id)
        {
            return db.pages.Find(id);
        }

        public IEnumerable<Pages> GetTopNews(int take = 4)
        {
            return db.pages.OrderByDescending(g => g.Visit).Take(take);
        }

        public void Insert(Pages page)
        {
            db.pages.Add(page);
        }

        public bool IsExists(int id)
        {
            return db.pages.Any(g => g.PageID == id);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<Pages> Search(string q)
        {
            return db.pages.Where(g => g.PageText.Contains(q) || g.PageGroup.GroupTitle.Contains(q) || g.PageDescription.Contains(q) || g.Tags.Contains(q) || g.Title.Contains(q));
        }

        public IEnumerable<Pages> ShowLastNews(int take = 4)
        {
            return db.pages.OrderByDescending(g => g.CreateTime).Take(take);
        }

        public IEnumerable<Pages> ShowSlider()
        {
            return db.pages.Where(g => g.ShowSlider == true);
        }

        public void Update(Pages page)
        {
            db.Entry(page).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
