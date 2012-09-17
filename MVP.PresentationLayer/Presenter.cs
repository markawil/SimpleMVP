using MVP.Domain;
using MVP.Model;

namespace MVP.PresentationLayer
{
   public class Presenter : IPresenter
   {
      private readonly IView _view;
      private readonly IPersonRepository _personRepository;

      public Presenter(IView view, IPersonRepository personRepository)
      {
         _view = view;
         _personRepository = personRepository;
      }

      public void SaveNewPerson(string name, string email)
      {
         if (!email.Contains("@"))
         {
            _view.NotifyOfInvalidation("email was not valid");
            return;
         }

         if (name == null || name.Length == 0)
         {
            _view.NotifyOfInvalidation("name was not valid");
            return;
         }

         var newPerson = new Person
                            {
                               Name = name,
                               Email = email
                            };

         _personRepository.Save(newPerson);  
         _view.NotifyOfSuccess();
      }
   }
}