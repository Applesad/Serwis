using Serwis.ViewModels.Person;
using Serwis.Models;
namespace Serwis.Interfaces
{
    public interface IPersonService
    {
        List<PersonForListVM> GetAllEntries();
        List<PersonForListVM> GetEntriesFromToday();
        void AddEntry(Person person);
    }
}
