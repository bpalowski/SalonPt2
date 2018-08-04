using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using HairSalon.Models;
//category
namespace HairSalon.Tests
{

    [TestClass]
    public class ClientTests : IDisposable
    {
        public ClientTests()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=brian_palowski_test;";
        }
        public void Dispose()
        {
          Client.DeleteAll();
        //  Category.DeleteAll();
        }

        [TestMethod]
       public void GetAll_ClientEmptyAtFirst_0()
       {
         //Arrange, Act
         int result = Stylist.GetAll().Count;

         //Assert
         Assert.AreEqual(0, result);
       }

       [TestMethod]
     public void Save_DatabaseAssignsIdToClient_Id()
     {
       //Arrange
       Client testClient = new Client("Household chores", 8);
       testClient.Save();


       //Act
       Client savedClient  = Client.GetAll()[0];

       int result = savedClient .GetId();
       int testId = testClient .GetId();

       //Assert
       Assert.AreEqual(testId, result);
    }



       [TestMethod]
       public void Find_FindsCategoryInDatabase_Category()
       {
         //Arrange
         Client testClient = new Client("Household chores", 0);
         testClient.Save();

         //Act
         Client foundClient = Client.Find(testClient.GetId());

         //Assert
         Assert.AreEqual(testClient, foundClient);
       }

       [TestMethod]
      public void Edit_String()
      {
        string first = "yes";
        Client testName = new Client(first, 1);
        testName.Save();
        string testNames = "Are it";

        //Act
        testName.Edit(testNames);

        string result = Client.Find(testName.GetId()).GetName();

        //Assert
        Assert.AreEqual(testNames , result);
      }
    //   [TestMethod]
    // public void Find_Test()
    // {
    //   //Arrange
    //   Client testClient = new Client("Jack", 3);
    //   testClient.Save();
    //   //Act
    //   Client result = Client.Find(testClient.GetId());
    //   //Assert
    //   Assert.AreEqual(testClient, result);
    // }

     }

    }
