using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WEBAQSEDE.Models;
using WEBAQSEDE.Models.Dominio;

namespace WEBAQSEDE.Controllers
{
    public class EntregadoresController : Controller
    {
        private readonly Contexto _context;

        public EntregadoresController(Contexto context)
        {
            _context = context;
        }

        // GET: Entregadores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Entregadores.ToListAsync());
        }

        // GET: Entregadores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entregador = await _context.Entregadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (entregador == null)
            {
                return NotFound();
            }

            return View(entregador);
        }

        // GET: Entregadores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Entregadores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,CPF,DataNascimento,Email,CEP,Cidade,Telefone,CNH")] Entregador entregador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(entregador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(entregador);
        }

        // GET: Entregadores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entregador = await _context.Entregadores.FindAsync(id);
            if (entregador == null)
            {
                return NotFound();
            }
            return View(entregador);
        }

        // POST: Entregadores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,CPF,DataNascimento,Email,CEP,Cidade,Telefone,CNH")] Entregador entregador)
        {
            if (id != entregador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(entregador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntregadorExists(entregador.Id))
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
            return View(entregador);
        }

        // GET: Entregadores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entregador = await _context.Entregadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (entregador == null)
            {
                return NotFound();
            }

            return View(entregador);
        }

        // POST: Entregadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var entregador = await _context.Entregadores.FindAsync(id);
            _context.Entregadores.Remove(entregador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EntregadorExists(int id)
        {
            return _context.Entregadores.Any(e => e.Id == id);
        }
    }
}
