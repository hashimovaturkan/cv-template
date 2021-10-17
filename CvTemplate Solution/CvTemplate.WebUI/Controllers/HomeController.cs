using CvTemplate.Domain.Models.DataContexts;
using CvTemplate.Domain.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CvTemplate.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly CvTemplateDbContext db;

        public HomeController(CvTemplateDbContext db)
        {
            this.db=db;
        }

        [HttpGet]
        public async Task<IActionResult> Contact()
        {
            var data =await db.PersonalSettings.FirstOrDefaultAsync(c => c.DeletedByUserId == null);
            return View(data);
        }


        [HttpPost]
        public async Task<IActionResult> Contact(ContactPost model)
        {
            if (ModelState.IsValid)
            {
                var post = new ContactPost();
                post.Comment = model.Comment;
                post.Email = model.Email;
                post.Name = model.Name;

                await db.ContactPosts.AddAsync(post);

                await db.SaveChangesAsync();

                return Json(new
                {
                    error = false,
                    message = "Your request has been successfully submitted"

                });
            }
            return Json(new
            {
                error = true,
                message = "Please try again.."

            });
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Resume()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            return View();
        }


    }
}
