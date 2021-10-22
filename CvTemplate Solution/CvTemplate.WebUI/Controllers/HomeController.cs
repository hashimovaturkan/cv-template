using CvTemplate.Domain.Models.DataContexts;
using CvTemplate.Domain.Models.Entities;
using CvTemplate.Domain.Models.ViewModels;
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
            var personalSetting =await db.PersonalSettings.FirstOrDefaultAsync(c => c.DeletedByUserId == null);
            var data = new ContactViewModel() {
                Location = personalSetting.Location,
                Phone = personalSetting.Phone,
                MainEmail = personalSetting.Email
            };

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

        public async Task<IActionResult> About()
        {
            var personalSettings = await db.PersonalSettings.FirstOrDefaultAsync(p => p.DeletedByUserId == null);
            var bio = await db.Bios.FirstOrDefaultAsync(p => p.DeletedByUserId == null);
            var services = await db.Services.Where(p => p.DeletedByUserId == null).ToListAsync();
            var skills = await db.Skills.Where(p => p.DeletedByUserId == null).ToListAsync();
            

            var data = new AboutViewModel()
            {
                PersonalSetting = personalSettings,
                Services = services,
                Skills = skills,
                Bio = bio

            };

            return View(data);
        }

        public async Task<IActionResult> Resume()
        {
            var academicBackGrounds= await db.AcademicBackGrounds.Where(p => p.DeletedByUserId == null).ToListAsync();
            var experiences = await db.Experiences.Where(p => p.DeletedByUserId == null).ToListAsync();
            var skills = await db.Skills.Where(p => p.DeletedByUserId == null).OrderBy(n=> n.IsBar).ToListAsync();
            var jobCategories = await (from jc in db.JobCategories 
                                join s in db.Skills on jc.Id equals s.JobCategoryId
                                select jc)
                                .ToListAsync();
            var bio = await db.Bios.FirstOrDefaultAsync(p => p.DeletedByUserId == null);

            var data = new ResumeViewModel() {
                AcademicBackGrounds = academicBackGrounds,
                Experiences = experiences,
                Skills = skills,
                Bio = bio,
                JobCategories = jobCategories.GroupBy(p => p.Id).Select(g=>g.First()).ToList()

            };

            return View(data);
        }

        public async Task<IActionResult> Portfolio()
        {
            var model =  new ProjectJobCategoryViewModel();
            model.Projects =await db.Projects.Where(p=>p.DeletedByUserId == null).ToListAsync();
            model.JobCategories = await db.JobCategories.Where(p => p.DeletedByUserId == null).ToListAsync();
            return View(model);
        }


    }
}
