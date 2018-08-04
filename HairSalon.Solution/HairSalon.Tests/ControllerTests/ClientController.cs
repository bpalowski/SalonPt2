using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Controllers;
using HairSalon.Models;

namespace HairSalon.Tests
{
  [TestClass]
  public class ClientControllerTest
  {
    [TestMethod]
      public void List_Returns_Clients()
      {
        //Arrange
      ClientsController controller = new ClientsController();

      //Act
      ActionResult listView = controller.List();

      //Assert
      Assert.IsInstanceOfType(listView, typeof(ViewResult));
    }
    [TestMethod]
      public void New_Clients()
      {
        //Arrange
      ClientsController controller = new ClientsController();

      //Act
      ActionResult createNew = controller.CreateForm();

      //Assert
      Assert.IsInstanceOfType(createNew, typeof(ViewResult));

  }
  [TestMethod]
    public void Update_Clients()
    {
      //Arrange
    ClientsController controller = new ClientsController();

    //Act
    ActionResult updateClient = controller.Up(2);

    //Assert
    Assert.IsInstanceOfType(updateClient, typeof(ViewResult));
}
[TestMethod]
  public void Delete_Clients()
  {
    //Arrange
  ClientsController controller = new ClientsController();

  //Act
  ActionResult deleteClient = controller.No(1);

  //Assert
  Assert.IsInstanceOfType(deleteClient, typeof(ViewResult));

}
[TestMethod]
  public void info_Of_Clients()
  {
    //Arrange
  ClientsController controller = new ClientsController();

  //Act
  ActionResult infoClient = controller.Info();

  //Assert
  Assert.IsInstanceOfType(infoClient, typeof(ViewResult));
}

}
}
