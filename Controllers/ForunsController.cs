using Microsoft.AspNetCore.Mvc;
using StarterPlatform.Data;

namespace StarterPlataform.Controllers
{
    public class ForunsController : Controller
    {
        private readonly ApplicationDbContext database;

        public ForunsController(ApplicationDbContext database)
        {
            this.database = database;
        }


    }
}