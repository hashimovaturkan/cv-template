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
using CvTemplate.Application.Modules.Admin.BlogCategoryModule;

namespace CvTemplate.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogCategoriesController : Controller
    {
        readonly IMediator mediator;

        public BlogCategoriesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        //[Authorize(Policy = "admin.personalsetting.index")]
        public async Task<IActionResult> Index(BlogCategoryPagedQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
                return NotFound();

            return View(response);
        }

        //[Authorize(Policy = "admin.personalsetting.details")]
        public async Task<IActionResult> Details(BlogCategorySingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        //[Authorize(Policy = "admin.personalsetting.create")]
        public async Task<IActionResult> Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Policy = "admin.personalsetting.create")]
        public async Task<IActionResult> Create(BlogCategoryCreateCommand command)
        {
            var response = await mediator.Send(command);
            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }

        //[Authorize(Policy = "admin.personalsetting.edit")]
        public async Task<IActionResult> Edit(BlogCategorySingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            var model = new BlogCategoryViewModel();
            model.Id = response.Id;
            model.Name = response.Name;
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Policy = "admin.personalsetting.edit")]
        public async Task<IActionResult> Edit(BlogCategoryUpdateCommand command)
        {
            var response = await mediator.Send(command);
            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }


        [HttpPost]
        //[Authorize(Policy = "admin.personalsetting.delete")]
        public async Task<IActionResult> Delete(BlogCategoryDeleteCommand command)
        {
            var response = await mediator.Send(command);
            return Json(response);
        }
    }
}
