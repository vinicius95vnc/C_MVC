﻿#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppMVC.Models;

namespace AppMVC.Controllers
{
    public class ParticipantesController : Controller
    {
        private readonly Context _context;

        public ParticipantesController(Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Participantes.ToListAsync());
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
        public async Task<IActionResult> Create([Bind("CodPar,Nome,DataNascimento,Telefone")] Participantes participantes)
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
        public async Task<IActionResult> Edit(string id, [Bind("CodPar,Nome,DataNascimento,Telefone")] Participantes participantes)
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