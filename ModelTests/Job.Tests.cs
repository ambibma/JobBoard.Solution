
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jobs.Models;
using System;

namespace Jobs.Tests
{
  [TestClass]

  public class ContactTests
  {
    Contact testContact;
    [TestInitialize]
    public void TestInitialize()
    {
      testContact = new Contact("Smith", "MrSmith@smithmail.com","555-555-555");
    }
    [TestMethod]
    public void ContactConstructor_CreatesNewContact_Contact()
    {
    Assert.AreEqual(typeof(Contact), testContact.GetType());
    }
  }
  [TestClass]

  public class JobsTests
  {
    Opening testOpening;
    Contact testContact;
    [TestInitialize]
    public void TestInitialize()
    {
      
      testContact = new Contact("Smith", "MrSmith@smithmail.com","555-555-555");
      testOpening = new Opening("Data Plumber", "You Plunge Data from servers", testContact);
    }
    [TestMethod]
    public void OpeningConstructor_CreatesNewOpening_Opening()
    {
    Assert.AreEqual(typeof(Opening), testOpening.GetType());
    }
  }
}
