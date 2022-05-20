using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Serwis.Interfaces;
using Serwis.ViewModels.Person;

namespace Serwis.Pages
{
    public class SavedModel : PageModel
    {
           
        private readonly IPersonService _personService;

        public SavedModel(IPersonService personService)
        {
            _personService = personService;
        }
        public IList<PersonForListVM> People { get; set; }
        
        public void OnGet()
        {
            People = _personService.GetAllEntries();
            People.OrderByDescending(p => p.Date);
        }
      
    }
}
