
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jobs.Models;
using System;

namespace Jobs.Tests
{
  [TestClass]

  public class JobsTests
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
}
