using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterControllerTest
    {
        [TestMethod]
        public void Create_ReturnsCorrectActionType_RedirectToActionResult()
        {
            //Arrange
            WordCounterController controller = new WordCounterController();

            //Act
            IActionResult view = controller.Create(0, "t", "t");

            //Assert
            Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
        }
    }
}