using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KoreMVC;
using KoreMVC.Models;

namespace KoreMVC.Controllers
{
    public class MembershipController : Controller
    {
        private readonly KoreMVCContext _context;

        public MembershipController(KoreMVCContext context)
        {
            _context = context;
        }

        // GET: Membership
        public async Task<IActionResult> Index()
        {
            var koreMVCContext = _context.Membership.Include(m => m.Cust).Include(m => m.MembershipFee);
            return View(await koreMVCContext.ToListAsync());
        }

        // GET: Membership/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Membership == null)
            {
                return NotFound();
            }

            var membership = await _context.Membership
                .Include(m => m.Cust)
                .Include(m => m.MembershipFee)
                .FirstOrDefaultAsync(m => m.MID == id);
            if (membership == null)
            {
                return NotFound();
            }

            return View(membership);
        }

        // GET: Membership/Create
        public IActionResult Create()
        {
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerId", "CustomerId");
            ViewData["MembershipTypeID"] = new SelectList(_context.MembershipFee, "MembershiptypeID", "MembershiptypeID");
            return View();
        }

        // POST: Membership/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MID,CustomerID,MembershipTypeID,MembershipTime")] Membership membership)
        {
            if (ModelState.IsValid)
            {
                _context.Add(membership);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerId", "CustomerId", membership.CustomerID);
            ViewData["MembershipTypeID"] = new SelectList(_context.MembershipFee, "MembershiptypeID", "MembershiptypeID", membership.MembershipTypeID);
            return View(membership);
        }

        // GET: Membership/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Membership == null)
            {
                return NotFound();
            }

            var membership = await _context.Membership.FindAsync(id);
            if (membership == null)
            {
                return NotFound();
            }
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerId", "CustomerId", membership.CustomerID);
            ViewData["MembershipTypeID"] = new SelectList(_context.MembershipFee, "MembershiptypeID", "MembershiptypeID", membership.MembershipTypeID);
            return View(membership);
        }

        // POST: Membership/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MID,CustomerID,MembershipTypeID,MembershipTime")] Membership membership)
        {
            if (id != membership.MID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(membership);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MembershipExists(membership.MID))
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
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerId", "CustomerId", membership.CustomerID);
            ViewData["MembershipTypeID"] = new SelectList(_context.MembershipFee, "MembershiptypeID", "MembershiptypeID", membership.MembershipTypeID);
            return View(membership);
        }

        // GET: Membership/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Membership == null)
            {
                return NotFound();
            }

            var membership = await _context.Membership
                .Include(m => m.Cust)
                .Include(m => m.MembershipFee)
                .FirstOrDefaultAsync(m => m.MID == id);
            if (membership == null)
            {
                return NotFound();
            }

            return View(membership);
        }

        // POST: Membership/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Membership == null)
            {
                return Problem("Entity set 'KoreMVCContext.Membership'  is null.");
            }
            var membership = await _context.Membership.FindAsync(id);
            if (membership != null)
            {
                _context.Membership.Remove(membership);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MembershipExists(int id)
        {
          return _context.Membership.Any(e => e.MID == id);
        }
    }
}
