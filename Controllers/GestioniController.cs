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

    public IActionResult AggiungiMarca()
    {
        return View();
    }

    // POST: Gestiscie la sottomisione del form
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult AggiungiMarca(string nome)
    {
        if (ModelState.IsValid)
        {
            var marca = new Marca
            {
                Nome = nome
            };

            _context.Marche.Add(marca);
            _context.SaveChangesAsync();
            
            return RedirectToAction("Index"); // Or to any other page, like a confirmation page
        }

        return View();
    }

    public IActionResult AggiungiMateriale()
    {
        return View();
    }

    // POST: Gestiscie la sottomisione del form
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult AggiungiMateriale(string nome)
    {
        if (ModelState.IsValid)
        {
            var materiale = new Materiale
            {
                Nome = nome
            };

            _context.Materiali.Add(materiale);
            _context.SaveChangesAsync();
            
            return RedirectToAction("Index"); // Or to any other page, like a confirmation page
        }

        return View();
    }
}
