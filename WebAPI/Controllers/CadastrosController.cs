using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;


namespace WebAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CadastrosController : ControllerBase
    {
        private readonly CadastroDBContext _context;

        public CadastrosController(CadastroDBContext context)
        {
            _context = context;
        }

        // GET: api/Cadastros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cadastro>>> GetCadastros()
        {
            return await _context.Cadastros.ToListAsync();
        }

        // GET: api/Cadastros/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cadastro>> GetCadastro(int id)
        {
            var cadastro = await _context.Cadastros.FindAsync(id);

            if (cadastro == null)
            {
                return NotFound();
            }

            return cadastro;
        }

        // PUT: api/Cadastros/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCadastro(int id, Cadastro cadastro)
        {
            if (id != cadastro.ID_funcionario)
            {
                return BadRequest();
            }

            _context.Entry(cadastro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CadastroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Cadastros
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cadastro>> PostCadastro(Cadastro cadastro)
        {
            _context.Cadastros.Add(cadastro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCadastro", new { id = cadastro.ID_funcionario }, cadastro);
        }

        // DELETE: api/Cadastros/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCadastro(int id)
        {
            var cadastro = await _context.Cadastros.FindAsync(id);
            if (cadastro == null)
            {
                return NotFound();
            }

            _context.Cadastros.Remove(cadastro);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CadastroExists(int id)
        {
            return _context.Cadastros.Any(e => e.ID_funcionario == id);
        }
    }
}
