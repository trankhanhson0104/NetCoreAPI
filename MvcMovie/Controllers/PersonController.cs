using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
     public class PersonController : Controller
     {
         private readonly ApplicationDbContext _context;
         public PersonController(ApplicationDbContext context)
         {
             _context = context;
         }

         public async Task<IActionResult> Index()
         {
            var model = await _context.Person.ToListAsync();
            return View(model);
         }
        
         public IActionResult Create()
         {
             return View();
         }
         [HttpPost]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> Create([Bind("PersonID,FullName,Address")]Person person)
         {
            if(ModelState.IsValid)
            {
                _context.Add(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(person);
         }
 
         public async Task<IActionResult> Edit(string id)
         {
             if(id == null || _context.Person == null)
             {
                 return NotFound();
             }
             var std = await _context.Person.FindAsync(id);
             if(std == null)
             {
                 return NotFound();
             }
             return View(std);
         }
         [HttpPost]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> Edit(string id,[Bind("PersonId, FullName, Address")] Person person)
         {
             if (id != person.PersonId)
             {
                 return NotFound();
             }
             if (ModelState.IsValid)
             {
                 try
                 {
                     _context.Update(person);
                     await _context.SaveChangesAsync();
                 }
                 catch (DbUpdateConcurrencyException)
                 {
                     if (!PersonExists(person.PersonId))
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
             return View(person);
         }
         public async Task<IActionResult> Delete(string id)
         {
             if (id == null || _context.Person == null)
             {
                 return NotFound();
             }
             var person = await _context.Person
             .FirstOrDefaultAsync(m => m.PersonId == id);
             if (person == null)
             {
                 return NotFound();
             }
             return View(person);
         }
         [HttpPost, ActionName("Delete")]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> DeleteConfirmed(string id)
         {
             if (_context.Person == null)
             {
                 return Problem("Entity set 'MyApp.Data.StudentContext.Student'  is null.");
             }
             var std = await _context.Person.FindAsync(id);
             if (std != null)
             {
                 _context.Person.Remove(std);
             }
             await _context.SaveChangesAsync();
             return RedirectToAction(nameof(Index));
         }
         private bool StudentExists(string id)
         {
             return (_context.Person?.Any(e => e.PersonId == id)).GetValueOrDefault();
         }
     }
}
 