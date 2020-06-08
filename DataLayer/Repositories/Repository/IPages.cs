using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repositories.Repository
{
    public interface IPages
    {
        IEnumerable<Pages> Getallpage();

        Pages GetByID(int id);

        void Insert(Pages page);

        void Update(Pages page);

        void Delete(Pages page);

        void Delete(int id);

        bool IsExists(int id);

        void Save();

        IEnumerable<Pages> ShowSlider();

        IEnumerable<Pages> GetTopNews(int take = 4);

        IEnumerable<Pages> ShowLastNews(int take = 4);

        IEnumerable<Pages> Search(string q);
    }
}
