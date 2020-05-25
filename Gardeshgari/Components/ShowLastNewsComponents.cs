using DataLayer.Repositories.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gardeshgari.Components
{
    public class ShowLastNewsComponents : ViewComponent
    {
        private IPages pages;

        public ShowLastNewsComponents(IPages pages)
        {
            this.pages = pages;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("ShowLastNewsComponents", pages.ShowLastNews()));
        }
    }
}
