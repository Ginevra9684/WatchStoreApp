using Microsoft.AspNetCore.Mvc;

public class ProdottiController : Controller
{
    private readonly ApplicationDbContext _context;

    public ProdottiController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index(int? minPrezzo, int? maxPrezzo, int? categoriaId, int? marcaId, int? materialeId, int? tipologiaId, int paginaCorrente = 1)
    {
        // Numero di default dei prodotti per pagina
        int prodottiPerPagina = 6;

        // Recupera tutte le categorie per il dropdown
        var categorie = _context.Categorie.ToList();
        var marche = _context.Marche.ToList();
        var materiali = _context.Materiali.ToList();
        var tipologie = _context.Tipologie.ToList();
        
        // Inizia a costruire la query
        List<Orologio> prodottiTotali = new List<Orologio>();
        foreach (Orologio orologio in _context.Orologi)
        {
            prodottiTotali.Add(orologio); 
        }
        // Prende il conteggio totale per la paginazione
        int quantitaProdotti = prodottiTotali.Count();

        // Applica la paginazione (Skip and Take)
        var prodotti = FiltraProdotti(prodottiTotali, minPrezzo, maxPrezzo, categoriaId, marcaId, materialeId, tipologiaId)
                            .Skip((paginaCorrente - 1) * prodottiPerPagina) // Salta gli oggetti della pagina corrente
                            .Take(prodottiPerPagina) // Prende gli oggetti della pagina corrente
                            .ToList(); // Esegue la query in modo asincrono
        
        var prodottiPaginati = prodotti.OrderBy(o => o.Prezzo).ToList();

        // Calcola il numero totale di pagine
        int numeroPagine = (int)Math.Ceiling((double)quantitaProdotti / prodottiPerPagina);

        // Prepara il viewmodel
        var viewModel = new ProdottiViewModel
        {
            Orologi = prodottiPaginati,
            MinPrezzo = minPrezzo ?? 0,
            MaxPrezzo = maxPrezzo ?? prodottiPaginati.Max(p => p.Prezzo),
            NumeroPagine = numeroPagine,
            PaginaCorrente = paginaCorrente,
            Categorie = categorie,  // Passa le categorie per il dropdown
            CategoriaSelezionata = categoriaId, // Passa la categoria selezionata, se presente
            Marche = marche,    // Passa le marche per il dropdown
            MarcaSelezionata = marcaId,  // Passa la marca selezionata, se presente
            Materiali = materiali,
            MaterialeSelezionato = materialeId,
            Tipologie = tipologie,
            TipologiaSelezionata = tipologiaId
        };
        return View(viewModel);
    }

    public List<Orologio> FiltraProdotti(List<Orologio> prodottiTotali, int? minPrezzo, int? maxPrezzo, int? categoriaId, int? marcaId, int? materialeId, int? tipologiaId)
    {
        List<Orologio> prodottiFiltrati = new List<Orologio>(); 
        bool scartato;

        foreach (var prodotto in prodottiTotali)
        {
            scartato = false;
            if(minPrezzo.HasValue && prodotto.Prezzo <= minPrezzo.Value)
            {
                scartato = true;
            }
            if(maxPrezzo.HasValue && prodotto.Prezzo >= maxPrezzo.Value)
            {
                scartato = true;
            }
            if(categoriaId.HasValue && prodotto.CategoriaId != categoriaId)
            {
                scartato = true;
            }
            if(marcaId.HasValue && prodotto.MarcaId != marcaId)
            {
                scartato = true;
            }
            if(materialeId.HasValue && prodotto.MaterialeId != materialeId)
            {
                scartato = true;
            }
            if(tipologiaId.HasValue && prodotto.TipologiaId != tipologiaId)
            {
                scartato = true;
            }
            if(scartato = false)
            {
                prodottiFiltrati.Add(prodotto);
            }
        }
        return prodottiFiltrati;
    }

    public IActionResult AggiungiCategoria(string nome)
    {
        var categoria = new Categoria { Nome = nome };
        _context.Categorie.Add(categoria);
        _context.SaveChanges();

        return RedirectToAction("Index", "Home"); 
    }
}