using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using HairSalon.Models;
//category
namespace HairSalon.Tests
{

    [TestClass]
    public class StylistTests : IDisposable
    {
        public StylistTests()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=brian_palowski_test;";
        }
        // public void Dispose()
        // {
        //   Stylist.DeleteAll();
        // //  Category.DeleteAll();
        // }

        [TestMethod]
       public void GetAll_CategoriesEmptyAtFirst_0()
       {
         //Arrange, Act
         int result = Stylist.GetAll().Count;

         //Assert
         Assert.AreEqual(0, result);
       }

       [TestMethod]
     public void Save_DatabaseAssignsIdToCategory_Id()
     {
       //Arrange
       Stylist testStylist = new Stylist("Household chores");
       testStylist.Save();

       //Act
       Stylist savedStylist  = Stylist.GetAll()[0];

       int result = savedStylist .GetStyId();
       int testId = testStylist .GetStyId();

       //Assert
       Assert.AreEqual(testId, result);
    }




       [TestMethod]
       public void Find_FindsCategoryInDatabase_Category()
       {
         //Arrange
         Stylist testStylist = new Stylist("Household chores");
         testStylist.Save();

         //Act
         Stylist foundStylist = Stylist.Find(testStylist.GetStyId());

         //Assert
         Assert.AreEqual(testStylist, foundStylist);
       }

       public void Dispose()
       {
         Stylist.DeleteAll();
         //Category.DeleteAll();
       }
       [TestMethod]
      public void Save_Stylist()
      {
        Stylist testStylist = new Stylist("pass");
        testStylist.Save();
      }
      [TestMethod]
     public void Saves_SavestoDatabase_GetAll_Stylist_List()
     {
       Stylist run = new Stylist("test3");

       //Act
       run.Save();
       List<Stylist> result = Stylist.GetAll();
       List<Stylist> testIt = new List<Stylist>{run};

       //Assert
       CollectionAssert.AreEqual(testIt, result);
     }
     [TestMethod]
    public void Edit_UpdatesStylistInDatabase_String()
    {
      string firstName = "Tests";
      Stylist testName = new Stylist(firstName, 1);
      testName.Save();
      string testSecondName = "Are fun";

      //Act
      testName.Edit(testSecondName);

      string result = Stylist.Find(testName.GetStyId()).GetStylistName();
      //Assert
      Assert.AreEqual(testSecondName , result);
     }
     [TestMethod]
    public void Get_String()
    {
      Speciality.GetAll();
   }
  //  [TestMethod]
  // public void Get_Specialitie()
  // {
  //   Speciality do = new Speciality(int.parse(1));
  //   do.Save();
  //
  //   Speciality showThe = Speciality.GetSpecialties(do.GetId());
  //
  //   Assert.AreEqual(do, showThe);



 }
}

    
