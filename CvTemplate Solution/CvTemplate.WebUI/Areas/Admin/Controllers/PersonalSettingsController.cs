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
using Microsoft.AspNetCore.Authorization;
using CvTemplate.Application.Modules.Admin.PersonalSettingsModule;
using CvTemplate.Application.Modules.Admin.UsersModule;

namespace CvTemplate.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PersonalSettingsController : Controller
    {
        readonly IMediator mediator;

        public PersonalSettingsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        //[Authorize(Policy = "admin.personalsetting.index")]
        public async Task<IActionResult> Index(PersonalSettingPagedQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
                return NotFound();

            return View(response);
        }

        //[Authorize(Policy = "admin.personalsetting.details")]
        public async Task<IActionResult> Details(PersonalSettingSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

           var category = await mediator.Send(new UserChooseQuery());
            ViewData["CvTemplateUserId"] = category.Where(b => b.Id == response.CvTemplateUserId).FirstOrDefault(b => b.DeletedByUserId == null).UserName;

            return View(response);
        }

        //[Authorize(Policy = "admin.personalsetting.create")]
        public async Task<IActionResult> Create()
        {
            ViewData["CvTemplateUserId"] = new SelectList(await mediator.Send(new UserChooseQuery()), "Id", "Username"??"Email");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Policy = "admin.personalsetting.create")]
        public async Task<IActionResult> Create(PersonalSettingCreateCommand command)
        {
            var response = await mediator.Send(command);
            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }

        //[Authorize(Policy = "admin.personalsetting.edit")]
        public async Task<IActionResult> Edit(PersonalSettingSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            ViewData["CvTemplateUserId"] = new SelectList(await mediator.Send(new UserChooseQuery()), "Id", "UserName", response.CvTemplateUserId);

            var vm = new PersonalSettingViewModel();
            vm.Id = response.Id;
            vm.Age = response.Age;
            vm.Name = response.Name;
            vm.Experience = response.Experience;
            vm.CareerLevel = response.CareerLevel;
            vm.Degree = response.Degree;
            vm.Location = response.Location;
            vm.Phone = response.Phone;
            vm.Fax = response.Fax;
            vm.Website = response.Website;
            vm.Email = response.Email;
            vm.CvTemplateUserId = response.CvTemplateUserId;
            return View(vm);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Policy = "admin.personalsetting.edit")]
        public async Task<IActionResult> Edit(PersonalSettingUpdateCommand command)
        {
            var response = await mediator.Send(command);
            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }


        [HttpPost]
        //[Authorize(Policy = "admin.personalsetting.delete")]
        public async Task<IActionResult> Delete(PersonalSettingDeleteCommand command)
        {
            var response = await mediator.Send(command);
            return Json(response);
        }
    }
}
