using MVP.Domain;

namespace MVP.PresentationLayer
{
   public interface IPresenter
   {
      void SaveNewPerson(string name, string email);
   }
}