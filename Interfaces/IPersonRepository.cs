using Serwis.Models;

namespace Serwis.Interfaces
{
    public interface IPersonRepository
    {
        IQueryable<Person> GetAllEntries();
        IQueryable<Person> GetEntriesFromToday();
        void AddEntry(Person person);
    }
}
     