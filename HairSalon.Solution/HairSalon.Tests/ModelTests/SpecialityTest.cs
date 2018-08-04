using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using HairSalon.Models;

namespace HairSalon.Tests
{

    [TestClass]
    public class SpecialityTests : IDisposable
    {
        public void Dispose()
        {
            Speciality.DeleteAll();
        }
        public SpecialityTests()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=brian_palowski_test;";
        }
        [TestMethod]
       public void GetAll_SpecialityEmptyAtFirst_0()
       {
         //Arrange, Act
         int result = Speciality.GetAll().Count;

         //Assert
         Assert.AreEqual(0, result);
       }
       [TestMethod]
      public void Find_Save_GetID_Speciality()
      {
        //Arrange
        Speciality testSpeciality = new Speciality("test1");
        testSpeciality.Save();
        //Act
        Speciality foundSpeciality = Speciality.Find(testSpeciality.GetId());


        Assert.AreEqual(testSpeciality, foundSpeciality);
      }
      [TestMethod]
     public void Save_Speciality()
     {
       Speciality testSave = new Speciality("testIt");
       testSave.Save();
     }
     [TestMethod]
    public void Saves_SavestoDatabase_GetAll_Speciality_List()
    {
      Speciality testIt = new Speciality("test2");

      //Act
      testIt.Save();
      List<Speciality> result = Speciality.GetAll();
      List<Speciality> testList = new List<Speciality>{testIt};

      //Assert
      CollectionAssert.AreEqual(testList, result);
    }
    [TestMethod]
   public void Edit_UpdatesSpecialityInDatabase_String()
   {
     string firstName = "Tests";
     Speciality testName = new Speciality(firstName, 1);
     testName.Save();
     string testSecondName = "Are fun";

     //Act
     testName.UpdateDescription(testSecondName);

     string result = Speciality.Find(testName.GetId()).GetDescription();

     //Assert
     Assert.AreEqual(testSecondName , result);
   }



    }
}
