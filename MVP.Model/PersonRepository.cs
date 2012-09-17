using System.Collections.Generic;
using System.Linq;
using MVP.Domain;

namespace MVP.Model
{
   public class PersonRepository : IPersonRepository
   {
      private IList<Person> _persons = new List<Person>();
      
      public void Save(Person person)
      {
         _persons.Add(person);
      }

      public Person GetByName(string name)
      {
         return _persons.FirstOrDefault(d => d.Name == name);
      }
   }
}