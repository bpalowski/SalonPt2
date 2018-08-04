using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Controllers;
using HairSalon.Models;

namespace HairSalon.Tests
{
  [TestClass]
  public class SpecialtiesControllerTest
  {
    [TestMethod]
      public void List_Specialities()
      {
        //Arrange
      SpecialityController controller = new SpecialityController();

      //Act
      ActionResult listSpeciality = controller.First();

      //Assert
      Assert.IsInstanceOfType(listSpeciality, typeof(ViewResult));
    }
    [TestMethod]
      public void Create_Specialities()
      {
        //Arrange
      SpecialityController controller = new SpecialityController();

      //Act
      ActionResult CreateSpeciality = controller.Show();

      //Assert
      Assert.IsInstanceOfType(CreateSpeciality, typeof(ViewResult));
    }
    [TestMethod]
      public void Info_Specialities()
      {
        //Arrange
      SpecialityController controller = new SpecialityController();

      //Act
      ActionResult InfoSpeciality = controller.Why(1);

      //Assert
      Assert.IsInstanceOfType(InfoSpeciality, typeof(ViewResult));
    }

  }
}
