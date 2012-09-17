using System.ComponentModel;
using MVP.Domain;
using MVP.Model;

namespace MVP.PresentationLayer
{
   public class ViewModel : IPresenter, INotifyPropertyChanged
   {
      private IPersonRepository _personRepo;
      private string _errorMessage;

      public ViewModel(IPersonRepository personRepo)
      {
         _personRepo = personRepo;
      }

      public void SaveNewPerson(string name, string email)
      {
         if (!email.Contains("@"))
         {
            ErrorMessage = "email was not valid";
            return;
         }

         if (name == null || name.Length == 0)
         {
            ErrorMessage = "name was not valid";
            return;
         }

         var newPerson = new Person
         {
            Name = name,
            Email = email
         };

         _personRepo.Save(newPerson);
         ErrorMessage = "Person was saved!";

      }

      public event PropertyChangedEventHandler PropertyChanged;

      protected virtual void OnPropertyChanged(string propertyName)
      {
         PropertyChangedEventHandler handler = PropertyChanged;
         if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
      }

      public string ErrorMessage
      {
         get { return _errorMessage; }
         set
         {
            _errorMessage = value;
            OnPropertyChanged("ErrorMessage");
         }
      }
   }
}