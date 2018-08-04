using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Controllers;
using HairSalon.Models;

namespace HairSalon.Tests
{
  [TestClass]
  public class StylistController
  {
    [TestMethod]
      public void Index_Of_Stylist()
      {
        StylistsController controller = new StylistsController();

        //Act
        ActionResult IndexView = controller.Index();

        //Assert
        Assert.IsInstanceOfType(IndexView, typeof(ViewResult));
      }
      [TestMethod]
        public void Create_Stylist()
        {
          StylistsController controller = new StylistsController();

          //Act
          ActionResult CreateStylist = controller.CStylist();

          //Assert
          Assert.IsInstanceOfType(CreateStylist, typeof(ViewResult));
        }
        [TestMethod]
          public void Update_Stylist()
          {
            StylistsController controller = new StylistsController();

            //Act
            ActionResult UpdateStylist = controller.New(1);

            //Assert
            Assert.IsInstanceOfType(UpdateStylist, typeof(ViewResult));
          }
          [TestMethod]
            public void All_Together()
            {
              StylistsController controller = new StylistsController();

              //Act
              ActionResult ShowAllInfo = controller.specialty(1);

              //Assert
              Assert.IsInstanceOfType(ShowAllInfo, typeof(ViewResult));
            }
    }
  }
