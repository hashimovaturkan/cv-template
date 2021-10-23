using CvTemplate.Domain.Models.DataContexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvTemplate.WebUI.Controllers
{
    public class BlogController : Controller
    {
        readonly CvTemplateDbContext db;
        public BlogController(CvTemplateDbContext db)
        {
            this.db = db;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {

            var list =await db.BlogPosts
                .Where(b => b.DeletedByUserId == null)
                .ToListAsync();

            return View(list);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var blog =await db.BlogPosts
                .FirstOrDefaultAsync(s => s.DeletedByUserId == null && s.Id == id);

            
            if(blog != null)
                return View(blog);

            ViewBag.Category = db.BlogCategories.FirstOrDefault(b => b.Id == blog.BlogCategoryId && b.DeletedByUserId == null).Name;

            return NotFound();
        }
    }
}
