using Serwis.Data;
using Serwis.Interfaces;
using Serwis.Models;

namespace Serwis.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PeopleContext _context;

        public PersonRepository(PeopleContext context)
        {
            _context = context;
        }

        public IQueryable<Person> GetAllEntries()
        {
            return _context.Person;
        }

        public IQueryable<Person> GetEntriesFromToday()
        {
            DateTime dateTime = DateTime.Today.AddDays(1);
            return _context.Person.Where(p => p.Data >= DateTime.Today && p.Data < dateTime);
        }

        public void AddEntry(Person person)
        {
            _context.Person.Add(person);
            _context.SaveChanges();
        }


    }
}
