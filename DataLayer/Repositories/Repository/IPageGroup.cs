using DataLayer.Model;
using DataLayer.ViewModels.VM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repositories.Repository
{
    public interface IPageGroup
    {
        IEnumerable<PageGroup> Getallpagegroup();

        PageGroup GetByID(int id);

        void Insert(PageGroup pagegroup);

        void Update(PageGroup pagegroup);

        void Delete(PageGroup pagegroup);

        void Delete(int pagegroupid);

        bool IsExists(int id);

        void Save();

        IEnumerable<ShowByCountVM> showByCountVMs();
    }
}
