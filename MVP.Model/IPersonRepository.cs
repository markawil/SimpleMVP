using MVP.Domain;

namespace MVP.Model
{
   public interface IPersonRepository
   {
      void Save(Person person);
      Person GetByName(string name);
   }
}