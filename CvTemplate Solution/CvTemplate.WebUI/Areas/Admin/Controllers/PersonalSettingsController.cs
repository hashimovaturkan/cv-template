using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CvTemplate.Domain.Models.DataContexts;
using CvTemplate.Domain.Models.Entities;

namespace CvTemplate.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PersonalSettingsController : Controller
    {
        private readonly CvTemplateDbContext _context;

        public PersonalSettingsController(CvTemplateDbContext context)
        {
            _context = context;
        }

        // GET: Admin/PersonalSettings
        public async Task<IActionResult> Index()
        {
            var cvTemplateDbContext = _context.PersonalSettings.Include(p => p.CvTemplateUser);
            return View(await cvTemplateDbContext.ToListAsync());
        }

        // GET: Admin/PersonalSettings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalSetting = await _context.PersonalSettings
                .Include(p => p.CvTemplateUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personalSetting == null)
            {
                return NotFound();
            }

            return View(personalSetting);
        }

        // GET: Admin/PersonalSettings/Create
        public IActionResult Create()
        {
            ViewData["CvTemplateUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Admin/PersonalSettings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Age,Location,Experience,Degree,CareerLevel,Phone,Fax,Website,Email,CvTemplateUserId,Id,CreatedByUserId,CreatedDate,DeletedByUserId,DeletedDate")] PersonalSetting personalSetting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personalSetting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CvTemplateUserId"] = new SelectList(_context.Users, "Id", "Id", personalSetting.CvTemplateUserId);
            return View(personalSetting);
        }

        // GET: Admin/PersonalSettings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalSetting = await _context.PersonalSettings.FindAsync(id);
            if (personalSetting == null)
            {
                return NotFound();
            }
            ViewData["CvTemplateUserId"] = new SelectList(_context.Users, "Id", "Id", personalSetting.CvTemplateUserId);
            return View(personalSetting);
        }

        // POST: Admin/PersonalSettings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Age,Location,Experience,Degree,CareerLevel,Phone,Fax,Website,Email,CvTemplateUserId,Id,CreatedByUserId,CreatedDate,DeletedByUserId,DeletedDate")] PersonalSetting personalSetting)
        {
            if (id != personalSetting.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personalSetting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonalSettingExists(personalSetting.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CvTemplateUserId"] = new SelectList(_context.Users, "Id", "Id", personalSetting.CvTemplateUserId);
            return View(personalSetting);
        }

        // GET: Admin/PersonalSettings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalSetting = await _context.PersonalSettings
                .Include(p => p.CvTemplateUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personalSetting == null)
            {
                return NotFound();
            }

            return View(personalSetting);
        }

        // POST: Admin/PersonalSettings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personalSetting = await _context.PersonalSettings.FindAsync(id);
            _context.PersonalSettings.Remove(personalSetting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonalSettingExists(int id)
        {
            return _context.PersonalSettings.Any(e => e.Id == id);
        }
    }
}
