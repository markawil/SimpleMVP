using System;
using System.Text;
using MVP.Domain;
using MVP.Model;
using NUnit.Framework;

namespace MVP.Tests
{
   [TestFixture]
   public class ModelTests
   {
      // System under test
      private IPersonRepository _personRepository;

      [SetUp]
      public void Setup()
      {
         _personRepository = new PersonRepository();
      }

      [Test]
      public void We_can_create_a_new_Person_Domain_obj()
      {
         var person = new Person();
         person.ShouldNotBe(null);     
      }

      [Test]
      public void We_can_set_a_persons_name_and_email()
      {
         var person = new Person();
         person.Name = "Mark";
         person.Email = "markawil@live.com";
         person.Name.ShouldBe("Mark");
         person.Email.ShouldBe("markawil@live.com");
      }

      [Test]
      public void We_can_persist_a_person()
      {
         var person = new Person
                         {
                            Name = "Mark W",
                            Email = "markawil@live.com"
                         };

         _personRepository.Save(person);
         Person person2 = _personRepository.GetByName(person.Name);
         person2.Name.ShouldBe("Mark W");
         person2.Email.ShouldBe("markawil@live.com");
      }
   }
}
