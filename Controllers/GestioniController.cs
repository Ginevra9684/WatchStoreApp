using Microsoft.AspNetCore.Mvc;

public class GestioniController : Controller
{
    private readonly ApplicationDbContext _context;

    public GestioniController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    // GET: Mostra il form per aggiungere una categoria
    public IActionResult AggiungiCategoria()
    {
        return View();
    }

    // POST: Gestiscie la sottomisione del form
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult AggiungiCategoria(string nome)
    {
        if (ModelState.IsValid)
        {
            var categoria = new Categoria
            {
                Nome = nome
            };

            _context.Categorie.Add(categoria);
            _context.SaveChangesAsync();
            
            return RedirectToAction("Index"); // Or to any other page, like a confirmation page
        }

        return View();
    }
}