using BibliotecaCentral.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaCentral.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LivrosController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Livros>>> GetLivros()
        {
            return await _context.livros.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult> AdicionarLivro(Models.Livros livro)
        {
            _context.livros.Add(livro);
            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}
