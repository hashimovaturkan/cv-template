using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CvTemplate.Domain.Models.DataContexts;
using CvTemplate.Domain.Models.Entities;
using MediatR;
using CvTemplate.Application.Modules.Admin.BlogPostModule;
using CvTemplate.Application.Modules.Admin.BlogCategoryModule;

namespace CvTemplate.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogPostsController : Controller
    {
        readonly IMediator mediator;

        public BlogPostsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        //[Authorize(Policy = "admin.academicbackgrounds.index")]
        public async Task<IActionResult> Index(BlogPostPagedQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
                return NotFound();

            return View(response);
        }

        //[Authorize(Policy = "admin.academicbackgrounds.details")]
        public async Task<IActionResult> Details(BlogPostSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }
            var category = await mediator.Send(new BlogCategoryChooseQuery());
            ViewData["BlogCategoryId"] = category.Where(b => b.Id == response.BlogCategoryId).FirstOrDefault(b => b.DeletedByUserId == null).Name;
            return View(response);
        }

        //[Authorize(Policy = "admin.academicbackgrounds.create")]
        public async Task<IActionResult> Create()
        {
            ViewData["BlogCategoryId"] = new SelectList(await mediator.Send(new BlogCategoryChooseQuery()), "Id", "Name");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Policy = "admin.academicbackgrounds.create")]
        public async Task<IActionResult> Create(BlogPostCreateCommand command)
        {
            var response = await mediator.Send(command);
            ViewData["BlogCategoryId"] = new SelectList(await mediator.Send(new BlogCategoryChooseQuery()), "Id", "Name", command.BlogCategoryId);
            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }

        //[Authorize(Policy = "admin.academicbackgrounds.edit")]
        public async Task<IActionResult> Edit(BlogPostSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            ViewData["BlogCategoryId"] = new SelectList(await mediator.Send(new BlogCategoryChooseQuery()), "Id", "Name", response.BlogCategoryId);

            var model = new BlogPostViewModel();
            model.Id = response.Id;
            model.Title = response.Title;
            model.Content = response.Content;
            model.PublishedDate = response.PublishedDate;
            model.ImgUrl = response.ImgUrl;
            model.BlogCategoryId = response.BlogCategoryId;
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Policy = "admin.academicbackgrounds.edit")]
        public async Task<IActionResult> Edit(BlogPostUpdateCommand command)
        {
            var response = await mediator.Send(command);
            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }


        [HttpPost]
        //[Authorize(Policy = "admin.academicbackgrounds.delete")]
        public async Task<IActionResult> Delete(BlogPostDeleteCommand command)
        {
            var response = await mediator.Send(command);
            return Json(response);
        }
    }
}
