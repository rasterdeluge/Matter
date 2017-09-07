using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MatterCentral.Data;
using MatterCentral.Models;

namespace MatterCentral.Controllers
{
    public class AccountsController : Controller
    {
        private readonly ALCContext _context;

        public AccountsController(ALCContext context)
        {
            _context = context;
        }

        // GET: Accounts
        public async Task<IActionResult> Index()
        {
            var aLCContext = _context.Accounts.Include(a => a.Type);
            return View(await aLCContext.ToListAsync());
        }
        
        // GET: Authorizations/List
        public async Task<IActionResult> List()
        {
            var model = new ListAccountViewModel(await _context.Accounts.Include(a => a.Type).ToListAsync());
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> GetStates(string _CountryId)
        {
            int CountryId;
            if(!int.TryParse(_CountryId, out CountryId)) {
                return null;
            }
            var States = await _context.States.Where(s => s.CountryId == CountryId).ToListAsync();
            return PartialView("_GetStates", new GetStatesViewModel(States));
        }

        [HttpGet]
        public async Task<IActionResult> GetCities(string _StateId)
        {
            int StateId;
            if (!int.TryParse(_StateId, out StateId)) {
                return null;
            }
            var Cities = await _context.Cities.Where(c => c.StateId == StateId).ToListAsync();
            return PartialView("_GetCities", new GetCitiesViewModel(Cities));
        }

        // GET: Accounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .Include(a => a.Type)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: Accounts/Create
        public async Task<IActionResult> Create()
        {
            var viewModel = new CreateAccountViewModel(new Account(), 
                                                        await _context.AccountTypes.ToListAsync(), 
                                                        await _context.PaymentTerms.ToListAsync(), 
                                                        await _context.Countries.ToListAsync()
                                                        );
            return View(viewModel);
        }

        // POST: Accounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,TypeId")] Account account)
        {
            if (ModelState.IsValid)
            {
                _context.Add(account);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TypeId"] = new SelectList(_context.AccountTypes, "Id", "Id", account.TypeId);
            return View(account);
        }

        // GET: Accounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts.SingleOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }
            ViewData["TypeId"] = new SelectList(_context.AccountTypes, "Id", "Id", account.TypeId);
            return View(account);
        }

        // POST: Accounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,TypeId")] Account account)
        {
            if (id != account.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(account);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.Id))
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
            ViewData["TypeId"] = new SelectList(_context.AccountTypes, "Id", "Id", account.TypeId);
            return View(account);
        }

        // GET: Accounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .Include(a => a.Type)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var account = await _context.Accounts.SingleOrDefaultAsync(m => m.Id == id);
            _context.Accounts.Remove(account);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountExists(int id)
        {
            return _context.Accounts.Any(e => e.Id == id);
        }
    }
}
