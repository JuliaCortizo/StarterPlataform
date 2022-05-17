using Microsoft.AspNetCore.Mvc;
using StarterPlataform.Models;
using StarterPlataform.Models.DTO;
using StarterPlatform.Data;

namespace StarterPlataform.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly ApplicationDbContext database;

        public CategoriasController(ApplicationDbContext database)
        {
            this.database = database;
        }

        [HttpPost]
        public IActionResult Salvar(CategoriaDTO categoriaDTO)
        {
            
            if(ModelState.IsValid)
            {
                Categoria categoria = new Categoria();
                categoria.Nome = categoriaDTO.Nome;
                categoria.Status = true;
                database.Categorias.Add(categoria);
                database.SaveChanges();
                return Ok("ok");
            }
            else
            {
                return Ok("fail");
            }
        }

    }
}