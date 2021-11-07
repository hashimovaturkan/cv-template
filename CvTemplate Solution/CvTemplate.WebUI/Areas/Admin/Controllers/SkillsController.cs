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
using CvTemplate.Application.Modules.Admin.SkillModule;
using CvTemplate.Application.Modules.Admin.JobCategoryModule;

namespace CvTemplate.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SkillsController : Controller
    {
        readonly IMediator mediator;

        public SkillsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        //[Authorize(Policy = "admin.academicbackgrounds.index")]
        public async Task<IActionResult> Index(SkillPagedQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
                return NotFound();

            return View(response);
        }

        //[Authorize(Policy = "admin.academicbackgrounds.details")]
        public async Task<IActionResult> Details(SkillSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }
            var category = await mediator.Send(new JobCategoryChooseQuery());
            ViewData["JobCategoryId"] = category.Where(b => b.Id == response.JobCategoryId).FirstOrDefault(b => b.DeletedByUserId == null).Name;


            return View(response);
        }

        //[Authorize(Policy = "admin.academicbackgrounds.create")]
        public async Task<IActionResult> Create()
        {
            ViewData["JobCategoryId"] = new SelectList(await mediator.Send(new JobCategoryChooseQuery()), "Id", "Name");

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Policy = "admin.academicbackgrounds.create")]
        public async Task<IActionResult> Create(SkillCreateCommand command)
        {
            var response = await mediator.Send(command);
            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }

        //[Authorize(Policy = "admin.academicbackgrounds.edit")]
        public async Task<IActionResult> Edit(SkillSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }
            ViewData["JobCategoryId"] = new SelectList(await mediator.Send(new JobCategoryChooseQuery()), "Id", "Name", response.JobCategoryId);


            var model = new SkillViewModel();
            model.Id = response.Id;
            model.Description = response.Description;
            model.Name = response.Name;
            model.Level = response.Level;
            model.IsBar = response.IsBar;
            model.JobCategoryId = response.JobCategoryId;
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Policy = "admin.academicbackgrounds.edit")]
        public async Task<IActionResult> Edit(SkillUpdateCommand command)
        {
            var response = await mediator.Send(command);
            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }


        [HttpPost]
        //[Authorize(Policy = "admin.academicbackgrounds.delete")]
        public async Task<IActionResult> Delete(SkillDeleteCommand command)
        {
            var response = await mediator.Send(command);
            return Json(response);
        }
    }
}
