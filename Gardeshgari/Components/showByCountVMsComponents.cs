using DataLayer.Repositories.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gardeshgari.Components
{
    public class showByCountVMsComponents : ViewComponent
    {
        private IPageGroup pageGroup;

        public showByCountVMsComponents(IPageGroup pageGroup)
        {
            this.pageGroup = pageGroup;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("showByCountVMsComponents", pageGroup.showByCountVMs()));
        }
    }
}
