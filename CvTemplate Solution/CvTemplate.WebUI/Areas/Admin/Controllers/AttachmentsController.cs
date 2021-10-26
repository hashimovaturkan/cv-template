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
using CvTemplate.Application.Modules.Admin.AttachmentModule;

namespace CvTemplate.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AttachmentsController : Controller
    {
        readonly IMediator mediator;

        public AttachmentsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        //[Authorize(Policy = "admin.personalsetting.index")]
        public async Task<IActionResult> Index(AttachmentPagedQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
                return NotFound();

            return View(response);
        }

        //[Authorize(Policy = "admin.personalsetting.details")]
        public async Task<IActionResult> Details(AttachmentSingleQuery query)
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
        public async Task<IActionResult> Create(AttachmentCreateCommand command)
        {
            var response = await mediator.Send(command);
            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }

        //[Authorize(Policy = "admin.personalsetting.edit")]
        public async Task<IActionResult> Edit(AttachmentSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            var model = new AttachmentViewModel();
            model.Id = response.Id;
            model.AttachmentUrl = response.AttachmentUrl;
            model.Name = response.Name;
            model.IconUrl = response.IconUrl;
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Policy = "admin.personalsetting.edit")]
        public async Task<IActionResult> Edit(AttachmentUpdateCommand command)
        {
            var response = await mediator.Send(command);
            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }


        [HttpPost]
        //[Authorize(Policy = "admin.personalsetting.delete")]
        public async Task<IActionResult> Delete(AttachmentDeleteCommand command)
        {
            var response = await mediator.Send(command);
            return Json(response);
        }
    }
}
