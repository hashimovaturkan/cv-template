using CvTemplate.Domain.Models.DataContexts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Application.Core.Components
{
    public class SidebarViewComponent:ViewComponent
    {
        readonly CvTemplateDbContext db;
        public SidebarViewComponent(CvTemplateDbContext db)
        {
            this.db = db;
        }
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
