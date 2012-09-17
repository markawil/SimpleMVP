using MVP.Domain;
using MVP.Model;
using MVP.PresentationLayer;
using NUnit.Framework;
using Rhino.Mocks;

namespace MVP.Tests
{
   [TestFixture]
   public class PresenterTests
   {
      //SUT
      private IPresenter _presenter;

      // Dependencies
      private IView _view;
      private IPersonRepository _personRepository;

      [SetUp]
      public void Setup()
      {
         _view = MockRepository.GenerateMock<IView>();
         _personRepository = MockRepository.GenerateMock<IPersonRepository>();
         _presenter = new Presenter(_view, _personRepository);
      }

      // Standard MVP pattern description
      [Test]
      public void Presenter_should_get_a_View()
      {
         IPresenter presenter;
         Assert.DoesNotThrow(() => presenter = new Presenter(_view, null));
      }

      [Test]
      public void Presenter_should_call_Save_on_repository_when_view_calls_save()
      {
         _presenter.SaveNewPerson("Mark", "markawil@yahoo.com");
         _personRepository.AssertWasCalled(d => d.Save(Arg<Person>.Matches(
            x => x.Name == "Mark" && x.Email == "markawil@yahoo.com")));
      }

      [Test]
      public void Presenter_should_call_NotifyOfInvalidation_on_view_if_name_or_email_were_invalid()
      {
         _presenter.SaveNewPerson("Mark", "1235");
         _view.AssertWasCalled(d => d.NotifyOfInvalidation("email was not valid"));
         _personRepository.AssertWasNotCalled(d => d.Save(Arg<Person>.Is.Anything));

         _presenter.SaveNewPerson(null, "markawil@yahoo.com");
         _view.AssertWasCalled(d => d.NotifyOfInvalidation("name was not valid"));
         _personRepository.AssertWasNotCalled(d => d.Save(Arg<Person>.Is.Anything));
      }

      [Test]
      public void Presenter_should_call_NotifyOfSuccess_on_view_if_new_person_was_saved()
      {
         _presenter.SaveNewPerson("Mark", "markawil@yahoo.com");
         _view.AssertWasCalled(d => d.NotifyOfSuccess());
      }
   }
}