# WatchStoreApp

## PIANIFICAZIONE

<details>
<summary>Steps</summary>

- [x] Identificazione delle pagine necessarie alla web app
- [x] Identificazione dei ViewModel per ogni pagina
- [x] Identificazione delle proprietà necessarie per ogni ViewModel
- [x] Decisione del tipo di utenti
- [x] Stabilire le diverse visualizzazione a seconda del tipo di utente
- [x] Identificazione del posizionamento dei link
- [x] Creazione layout senza logiche backend
- [x] Implementazione delle partialViews
- [x] Inizializzare l'archetico della WebApp
- - [x] dotnet new mvc -o WatchStoreApp --auth Individual
- - [x] dotnet add package Microsoft.EntityFrameworkCore.Sqlite
- - [x] dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
- - [x] assicurarsi che ApplicationDbContext erediti da IdentityDbContext
- - [x] dotnet ef migrations add InitialCreate
- - [x] dotnet ef database update
- - [x] aggiunte a program.cs per la creazione dei ruoli
- [x] Creare git.ignore e aggiungere progetto alla sln
- [x] Effettuare lo scaffolding delle pagine entity che si desidera personalizzare
- - [x] dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
- - [x] dotnet tool install -g dotnet-aspnet-codegenerator
- - [x] dotnet aspnet-codegenerator identity -dc ApplicationDbContext --files "Account.Login;Account.Logout;Account.Register;Account.Manage.Index"
- [x] Creazione dei modelli base relativi ai prodotti
- [x] Creazione dei DBset e update del database
- [ ] Decisione degli stili condivisi con css
- [ ] Listare i metodi necessari per ogni pagina
- [ ] Conservazione di fonti multimediali (loghi, fonts, video ecc)
- [ ] Controllare la presenza di CDN e pacchetti da installare
- [x] Decisione della lingua
- [x] Decisione dello standard del codice e dei commenti
- [x] Divisione del lavoro su più branch

</details>

## Pagine

- HOME
<details>
<summary>Descrizione</summary>

- Visualizzazione di un carousel di cards con i prodotti più venduti
- Visualizzazione di un carousel di cards con gli ultimi arrivi
- Da ogni card è possibile accedere alla pagina dettaglio prodotto
- Nella pagina sarà presente un pulsante per accedere alla pagina con tutti i prodotti
- Dalle card si potrà aggiungere i prodotti al carrello

</details>

<details>
<summary>Lista link</summary>

- Pagina prodotti
- Pagina dettaglio prodotto
- Partial view carrello

</details>

<details>
<summary>ViewModel</summary>

```C#
public class HomeViewModel
{
    public List<Orologio> ProdottiPiuVenduti
    public List<Orologio> UltimiArrivi
}
```

</details>

<details>
<summary>Metodi Controller</summary>

</details>

<details>
<summary>View</summary>

</details>

- PRODOTTI

<details>
<summary>Descrizione</summary>

VERSIONE NORMALE :

- Visualizzazione di tutti i prodotti inpaginati
- Filtro per prezzo
- Filtro per data di aggiunta
- Filtro per categoria
- Filtro per marca
- Filtro per materiale 
- Filtro per tipologia
- Filtro per Genere
- Su schermo grande i filtri saranno in una sidebar
- Su schermo piccolo i filtri saranno dei pulsanti in alto
- Ogni card ha un pulsante per aggiungere alla wishlist
- Ogni card ha un pulsante per aprire e aggiungere al carrello

AGGIUNTE ADMIN :

- Pulsante card per eliminare il prodotto
- Pulsante card per modificare il prodotto

</details>

<details>
<summary>Lista link</summary>

- Pagina dettaglio prodotto
- Partial view carrello


AGGIUNTE ADMIN : 

- Pagina elimina prodotto
- Pagina modifica prodotto

</details>

<details>
<summary>ViewModel</summary>

```C#
public class ProdottiViewModel
{
    public List<Orologio> Orologi {get; set;}
    public List<Categoria> Categorie {get; set;}
    public List<Marca> Marche {get; set;}
    public List<Materiale> Materiali {get; set;}
    public List<Tipologia> Tipologie {get; set;}
    public List<Genere> Generi {get; set;}
    public decimal MinPrezzo { get; set; }
    public decimal MaxPrezzo { get; set; }
    public int NumeroPagine { get; set; }
    public int PaginaCorrente { get; set; }
}
```

</details>

<details>
<summary>Metodi Controller</summary>

</details>

<details>
<summary>View</summary>

</details>

- AGGIUNGI PRODOTTO

<details>
<summary>Descrizione</summary>

SOLO ADMIN :

- Permette di visualizzare un form per aggiungere un nuovo prodotto
- Molte caratteristiche potranno essere inserite tramite menu a tendina per poter accedere ad un elenco di una determinata proprietà

</details>

<details>
<summary>Lista link</summary>

- Pagina prodotti

</details>

<details>
<summary>ViewModel</summary>

```C#
public class AggiungiProdottoViewModel
{
    public Orologio Orologio {get; set;}
    public List<Categoria> Categorie {get; set;}
    public List<Marca> Marche {get; set;}
    public List<Materiale> Materiali {get; set;}
    public List<Tipologia> Tipologie {get; set;}
    public List<Genere> Generi {get; set;}
}
```

</details>

<details>
<summary>Metodi Controller</summary>

</details>

<details>
<summary>View</summary>

</details>

- MODIFICA PRODOTTO

<details>
<summary>Descrizione</summary>

SOLO ADMIN :

- Permette di visualizzare tutte le caratteristiche di un prodotto e modificarle

</details>

<details>
<summary>Lista link</summary>

- Pagina prodotti

</details>

<details>
<summary>ViewModel</summary>

```C#
public class ModificaProdottoViewModel
{
    public Orologio Orologio {get; set;}
}
```

</details>

<details>
<summary>Metodi Controller</summary>

</details>

<details>
<summary>View</summary>

</details>

- ELIMINA PRODOTTO

<details>
<summary>Descrizione</summary>

SOLO ADMIN :

- Permette di visualizzare le caratteristiche principali del prodotto e di eliminarlo

</details>

<details>
<summary>Lista link</summary>

- Pagina prodotti
- Pagina dettaglio prodotto

</details>

<details>
<summary>ViewModel</summary>

```C#
public class EliminaProdottoViewModel
{
    public Orologio Orologio {get; set;}
}
```

</details>

<details>
<summary>Metodi Controller</summary>

</details>

<details>
<summary>View</summary>

</details>

- DETTAGLIO PRODOTTO

<details>
<summary>Descrizione</summary>

- Permette di visualizzare tutti i dettagli specifici di un oggetto
- Contiene una descrizione aggiuntiva dettagliata
- La pagina avrà una sezione con sfondo diverso per le specifiche tecniche
- Le specifiche saranno visualizzate tramite tab panels

</details>

<details>
<summary>Lista link</summary>

- Partial view carrello
- Pagina prodotti

</details>

<details>
<summary>ViewModel</summary>

```C#
public class DettaglioProdottoViewModel
{
    public Orologio Orologio {get; set;}
    public string Descrizione {get; set;}
}
```

</details>

<details>
<summary>Metodi Controller</summary>

</details>

<details>
<summary>View</summary>

</details>

- PROFILO UTENTE

<details>
<summary>Descrizione</summary>

- Visualizzazione dei dati personali dell'utente
- Sidebar con bottoni
- Bottone per vedere la wishlist
- Bottone per vedere la pagina ordini effettuati
- (Bottone inpostazioni)
- (Se l'utente è stato bannato da un admin verrà visualizzata una scritta indicante ciò)

</details>

<details>
<summary>Lista link</summary>

- Pagina ordini
- partial view wishlist
- (Pagina inpostazioni)
- (partial view bannato)

</details>

<details>
<summary>ViewModel</summary>

```C#
public class ProfiloUtenteViewModel
{
    public Cliente Cliente {get; set;}
    public List<Ordine> Ordini {get; set;}
    public List<Orologio> Wishlist {get; set;}
    public string NomeUtente {get; set;}
    public string Email {get; set;}
}
```

</details>

<details>
<summary>Metodi Controller</summary>

</details>

<details>
<summary>View</summary>

</details>

- PROFILO ADMIN

<details>
<summary>Descrizione</summary>

- Visualizzazione dei dati personali dell'utente
- Sidebar con bottoni
- Bottone per vedere la wishlist
- Bottone per vedere la pagina ordini effettuati
- Bottone aggiungi prodotto
- Bottone visualizza utenti
- (Bottone inpostazioni)

</details>

<details>
<summary>Lista link</summary>

- Pagina ordini
- Partial view wishlist
- Pagina lista utenti
- (Pagina inpostazioni)
- (partial view ban utente)

</details>

<details>
<summary>ViewModel</summary>

```C#
public class ProfiloAdminViewModel
{
    public Cliente Cliente {get; set;}
    public List<Ordine> Ordini {get; set;}
    public List<Orologio> Wishlist {get; set;}
    public List<Cliente> Clienti {get; set;}
    public string NomeUtente {get; set;}
    public string Email {get; set;}
}
```

</details>

<details>
<summary>Metodi Controller</summary>

</details>

<details>
<summary>View</summary>

</details>

- LOGIN
- REGISTER

- ORDINI

<details>
<summary>Descrizione</summary>

- Visualizzazione di tutti gli ordini effettuati da un utente
- Bottone per tornare al proprio profilo
- Bottone in ogni ordine per visualizzarne i dettagli

</details>

<details>
<summary>Lista link</summary>

- Pagina profilo 
- Dettagli ordine

</details>

<details>
<summary>ViewModel</summary>

```C#
public class OrdiniViewModel
{
    public Cliente Cliente {get; set;}
    public List<Ordine> Ordini {get; set;}
}
```

</details>

<details>
<summary>Metodi Controller</summary>

</details>

<details>
<summary>View</summary>

</details>

- DETTAGLIO ORDINE

<details>
<summary>Descrizione</summary>

- Visualizzazione dei dettagli di un ordine specifico
- Bottone per tornare alla pagina ordini

</details>

<details>
<summary>Lista link</summary>

- Pagina ordini

</details>

<details>
<summary>ViewModel</summary>

```C#
public class OrdiniViewModel
{
    public Ordine Ordine {get; set;}
}
```

</details>

<details>
<summary>Metodi Controller</summary>

</details>

<details>
<summary>View</summary>

</details>



<details>
<summary>MODELLI GENERICI</summary>

GENERALE

```c#
public abstract class General
{
    public virtual int Id { get; set; }
    public virtual string Nome { get; set; } = "";
}

```

PRODOTTO

```c#
public class Prodotto : General
{
    public decimal Prezzo { get; set; } // Prezzo del prodotto
    public int Giacenza { get; set; }   // Quantità disponibile in magazzino
    public string? Colore { get; set; }
    public Categoria? Categoria { get; set; }  // Relazione con la categoria
    // Identificatore della categoria a cui appartiene il prodotto
    public int? Id_categoria { get; set; } //Rimuovere id_categoria 
    public Marca? Marca{get; set;}    
    // public int? MarcaId;
}

```

OROLOGIO

```c#
public class Orologio : Prodotto
{
    public string Modello{ get; set; }
    public string Referenza{ get; set; }
    public Materiale Materiale { get; set; }
    public Tipologia Tipologia { get; set; }
    public int Diametro { get; set; }
    public Genere Genere {get; set; }
}

```

CATEGORIA

```c#
public class Categoria : General
{

} 

```

MARCA

```c#
public class Marca : General
{

} 

```

MATERIALE 

```c#
public class Materiale : General
{

} 

```

TIPOLOGIA 

```c#
public class Tipologia : General
{

} 

```

GENERE 

```c#
public class Genere : General
{

} 

```
</details>

## PARTIAL VIEWS

- CARRELLO

<details>
<summary>Descrizione</summary>

- Per vedere tutti gli ordini aggiunti al carrelo
- Per accedere alla conferma dell'ordine

</details>

<details>
<summary>Lista link</summary>

- Pagina conferma ordine

</details>

<details>
<summary>ViewModel</summary>

```C#
public class CarrelloViewModel
{
    public List<Orologio> Carrello {get; set;}
}
```

</details>

<details>
<summary>Metodi Controller</summary>

</details>

<details>
<summary>View</summary>

</details>

- WISHLIST

<details>
<summary>Descrizione</summary>

- Per vedere tutti gli articoli desiderati

</details>

<details>
<summary>Lista link</summary>

- Pagina dettaglio prodotto

</details>

<details>
<summary>ViewModel</summary>

```C#
public class WishlistViewModel
{
    public List<Orologio> Wishlist {get; set;}
}
```
</details>

<details>
<summary>Metodi Controller</summary>

</details>

<details>
<summary>View</summary>

</details>

- NAVBAR

<details>
<summary>Descrizione</summary>

GENERALE :

- Logo store
- bottone home
- Barra di ricerca
- Login (/logout) - Register
- Menu per selezionare prodotti
- Bottone pagina prodotti
- Logo carrello

AGGIUNTE USER : 

- Logo profilo

AGGIUNTE ADMIN : 

- Bottone aggiungi prodotto

</details>

<details>
<summary>Lista link</summary>

GENERALE :

- Pagina home
- Pagina login
- Pagina register
- Pagina prodotti
- Partial view carrello

AGGIUNTE USER : 

- Pagina profilo

AGGIUNTE ADMIN : 

- Pagina aggiungi prodotto

</details>

<details>
<summary>Metodi Controller</summary>

</details>

<details>
<summary>View</summary>

</details>

- FOOTER

<details>
<summary>Descrizione</summary>

- Descrizioni generale del sito
- Contatti
- Link esterni ai socials

</details>

<details>
<summary>Lista link</summary>

- Links socials

</details>

<details>
<summary>Metodi Controller</summary>

</details>

<details>
<summary>View</summary>

</details>

<details>
<summary>CDN</summary>

</details>

<details>
<summary>Loghi</summary>

</details>

<details>
<summary>Fonts</summary>

</details>

<details>
<summary>CSS</summary>

```CSS

```

</details>

<details>
<summary>Standards codice</summary>

- Metodi scritti in PascalCase
- Proprietà dei modelli scritti in PascalCase
- Variabili scritte in camelCase
- Commenti corti e non ripetitivi
- Corrispondenza delle variabili tra i vari file

</details>

<details>
<summary>Schema collegamenti pagine</summary>

```mermaid

```

</details>

<details>
<summary>Ultimi Steps</summary>

- Controllo eccezioni
- Revisione commenti e nomenclature
- Placeholders
- Arials
- Test App

</details>