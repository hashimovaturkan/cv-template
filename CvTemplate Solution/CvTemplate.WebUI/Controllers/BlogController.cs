using CvTemplate.Domain.Models.DataContexts;
using CvTemplate.Domain.Models.Entities;
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

        [HttpPost]
        public async Task<IActionResult> PostComment(int? commentId, int postId, string comment)
        {
            if (string.IsNullOrWhiteSpace(comment))
            {
                return Json(new
                {
                    error = true,
                    message = "Serh bos buraxila bilmez!"
                });
            }

            if (postId < 1)
            {
                return Json(new
                {
                    error = true,
                    message = "Post movcud deyil!"
                });
            }


            var post = await db.BlogPosts.FirstOrDefaultAsync(c => c.Id == postId);


            if (post == null)
            {
                return Json(new
                {
                    error = true,
                    message = "Post movcud deyil!"
                });
            }

            var commentModel = new BlogPostComment
            {
                ParentId = commentId,
                BlogPostId = postId,
                Comment = comment
                //,CreatedByUserId= User.GetCurrentUserId()
            };
            if (commentId.HasValue && await db.BlogPostComments.AnyAsync(c => c.Id == commentId))
                commentModel.ParentId = commentId;

            await db.BlogPostComments.AddAsync(commentModel);
            await db.SaveChangesAsync();



            //return Json(new
            //{
            //    error = false,
            //    message = "Elave edildi!"
            //});
            commentModel = await db.BlogPostComments
                .Include(c => c.CreatedByUserId)
                .Include(c => c.Parent)
                .FirstOrDefaultAsync(c => c.Id == commentModel.Id);

            return PartialView("_Comment", commentModel);
        }
    }
}
