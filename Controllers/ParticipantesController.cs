using AppMVC.Models;
using AppMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace AppMVC.Controllers
{
    
    public class ParticipantesController : Controller
    {
        private readonly Context _context;

        public ParticipantesController(Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var participantes = from nome in _context.Participantes select nome;

            if (!string.IsNullOrEmpty(searchString))
            {
                participantes = participantes.Where(n => n.Nome.Contains(searchString));
            }

            return View(await _context.Participantes.ToListAsync());
        }

        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "Paticipante" + searchString;
        }

        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participantes = await _context.Participantes
                .FirstOrDefaultAsync(m => m.CodPar == id);
            if (participantes == null)
            {
                return NotFound();
            }

            return View(participantes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodPar,Nome,DataCriacao,UltimaAtualizacao,Telefone")] Participantes participantes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(participantes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(participantes);
        }

        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participantes = await _context.Participantes.FindAsync(id);
            if (participantes == null)
            {
                return NotFound();
            }
            return View(participantes);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CodPar,Nome,DataCriacao,UltimaAtualizacao,Telefone")] Participantes participantes)
        {
            if (id != participantes.CodPar)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(participantes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParticipantesExists(participantes.CodPar))
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
            return View(participantes);
        }

        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participantes = await _context.Participantes
                .FirstOrDefaultAsync(m => m.CodPar == id);
            if (participantes == null)
            {
                return NotFound();
            }

            return View(participantes);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var participantes = await _context.Participantes.FindAsync(id);
            _context.Participantes.Remove(participantes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParticipantesExists(string id)
        {
            return _context.Participantes.Any(e => e.CodPar == id);
        }
    }
}
