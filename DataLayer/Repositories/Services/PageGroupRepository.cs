using DataLayer.Context;
using DataLayer.Model;
using DataLayer.Repositories.Repository;
using DataLayer.ViewModels.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Repositories.Services
{
    public class PageGroupRepository : IPageGroup
    {
        private GardeshgariDbContext db;
        public PageGroupRepository(GardeshgariDbContext context)
        {
            this.db = context;
        }
        public void Delete(PageGroup pagegroup)
        {
            db.Entry(pagegroup).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        }

        public void Delete(int pagegroupid)
        {
            var fordelete = GetByID(pagegroupid);
            Delete(fordelete);
        }

        public IEnumerable<PageGroup> Getallpagegroup()
        {
            return db.pageGroups.ToList();
        }

        public PageGroup GetByID(int id)
        {
            return db.pageGroups.Find(id);
        }

        public void Insert(PageGroup pagegroup)
        {
            db.pageGroups.Add(pagegroup);
        }

        public bool IsExists(int id)
        {
            return db.pageGroups.Any(g => g.GroupID == id);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<ShowByCountVM> showByCountVMs()
        {
            return db.pageGroups.Select(g => new ShowByCountVM()
            {
                GroupID = g.GroupID,
                GroupTitle = g.GroupTitle,
                PageCount = g.Pages.Count
            });
        }

        public void Update(PageGroup pagegroup)
        {
            db.Entry(pagegroup).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
