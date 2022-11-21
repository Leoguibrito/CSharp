using Microsoft.AspNetCore.Mvc;
using API_Catalogo.Context;
using API_Catalogo.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Catalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly ApiCatalogContext _context;
        public ProdutosController(ApiCatalogContext context)
        {
            _context = context;
        }

        // GET: api/<ProdutosController>
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            var produtos = _context.Produtos.AsNoTracking().ToList();
            if (produtos is null)
            {
                return NotFound("Produtos não Encontrado");
            }
            return produtos;
        }

        // GET api/<ProdutosController>/5
        [HttpGet("{id::int}", Name="ObterProduto")]
        public ActionResult<Produto> Get(int id)
        {
            var produto = _context.Produtos.AsNoTracking().FirstOrDefault(p => p.ProdutoId == id);
            if (produto is null)
            {
                return NotFound("Produto Não Encontrado");
            }
            return produto;
        }

        // POST api/<ProdutosController>
        [HttpPost]
        public ActionResult Post(Produto produto)
        {
            if (produto == null)
            {
                return BadRequest("Produto Não Existe");
            }
            _context.Produtos.Add(produto);

            ApiCatalogContext.Produtos.ExecuteSqlCommand("SET IDENTITY_INSERT CatalogoDB.leoguteste ON;");
            _context.SaveChanges();
            ApiCatalogContext.Produtos.ExecuteSqlCommand("SET IDENTITY_INSERT CatalogoDB.leoguteste OFF");
            

            return new CreatedAtRouteResult("ObterProduto", new { id = produto.ProdutoId }, produto);
        }

        // PUT api/<ProdutosController>/5
        [HttpPut("{id::int}")]
        public ActionResult Put(int id, Produto produto)
        {
            if (id != produto.ProdutoId)
            {
                return BadRequest();
            }

            _context.Entry(produto).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(produto);
        }

        // DELETE api/<ProdutosController>/5
        [HttpDelete("{id::int}")]
        public ActionResult Delete(int id)
        {
            var produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);
            if (produto is null)
            {
                return NotFound("Produto Não Encontrado");
            }
            _context.Produtos.Remove(produto);
            _context.SaveChanges();

            return Ok(produto);
        }
    }
}
