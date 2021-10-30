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
using CvTemplate.Application.Modules.Admin.ContactPostModule;
using Microsoft.AspNetCore.Authorization;

namespace CvTemplate.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactPostsController : Controller
    {
        readonly IMediator mediator;

        public ContactPostsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        //[Authorize(Policy = "admin.contactposts.index")]
        public async Task<IActionResult> Index(ContactPostPagedQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
                return NotFound();

            return View(response);
        }

        //[Authorize(Policy = "admin.contactposts.details")]
        public async Task<IActionResult> Details(ContactPostSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        [HttpPost]
        [Authorize(Policy = "admin.contactposts.answer")]
        public async Task<IActionResult> Answer(ContactPostAnswerCommand model)
        {
            var response = await mediator.Send(model);

            if (response == null)
                return NotFound();

            return Redirect(nameof(Index));
        }

    }
}
