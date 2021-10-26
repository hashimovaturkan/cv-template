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
using CvTemplate.Application.Modules.Admin.AcademicBackGroundModule;

namespace CvTemplate.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AcademicBackGroundsController : Controller
    {
        readonly IMediator mediator;

        public AcademicBackGroundsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        //[Authorize(Policy = "admin.academicbackgrounds.index")]
        public async Task<IActionResult> Index(AcademicBackGroundPagedQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
                return NotFound();

            return View(response);
        }

        //[Authorize(Policy = "admin.academicbackgrounds.details")]
        public async Task<IActionResult> Details(AcademicBackGroundSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        //[Authorize(Policy = "admin.academicbackgrounds.create")]
        public async Task<IActionResult> Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Policy = "admin.academicbackgrounds.create")]
        public async Task<IActionResult> Create(AcademicBackGroundCreateCommand command)
        {
            var response = await mediator.Send(command);
            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }

        //[Authorize(Policy = "admin.academicbackgrounds.edit")]
        public async Task<IActionResult> Edit(AcademicBackGroundSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            var model = new AcademicBackGroundViewModel();
            model.Id = response.Id;
            model.Degree = response.Degree;
            model.Name = response.Name;
            model.Qualification = response.Qualification;
            model.University = response.University;
            model.Details = response.Details;
            model.StartingDate = response.StartingDate;
            model.EndingDate = response.EndingDate;
            model.ImageUrl = response.ImageUrl;
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Policy = "admin.academicbackgrounds.edit")]
        public async Task<IActionResult> Edit(AcademicBackGroundUpdateCommand command)
        {
            var response = await mediator.Send(command);
            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }


        [HttpPost]
        //[Authorize(Policy = "admin.academicbackgrounds.delete")]
        public async Task<IActionResult> Delete(AcademicBackGroundDeleteCommand command)
        {
            var response = await mediator.Send(command);
            return Json(response);
        }
    }
}
