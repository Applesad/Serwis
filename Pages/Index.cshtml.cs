using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Serwis.Data;
using Serwis.Models;
using Newtonsoft.Json;
using Serwis.Interfaces;
using Serwis.ViewModels.Person;

namespace Serwis.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IPersonService _personService;

        [BindProperty]
        public Person Person { get; set; }
        public List<PersonForListVM>? People { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService; 
        }

        public void OnGet()
        {
            People = _personService.GetEntriesFromToday();
            People.OrderByDescending(p => p.Date);
        }
        public IActionResult OnPost()
        {
            //People = _context.Person.ToList();
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (ModelState.IsValid)
            {
                Person.SprawdzPrzestepnosc();
                TempData["AlertMessage"] = Person.FirstName + " " + Person.LastName + " urodzil/a sie w " + Person.RokUrodzenia + ". Byl to rok " + Person.Rok;
                _personService.AddEntry(Person);
            }
            People = _personService.GetEntriesFromToday();
            People.OrderByDescending(p => p.Date);
            return RedirectToPage("./Index");
        }

    }
}