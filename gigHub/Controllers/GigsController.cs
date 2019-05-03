using gigHub.Models;
using gigHub.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace gigHub.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Create()
        {
            var viewModel = new GigFromViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }
    }
}