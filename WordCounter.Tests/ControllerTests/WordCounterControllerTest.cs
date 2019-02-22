using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterControllerTest
    {
        // Testing for HttpGet actions

        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            WordCounterController controller = new WordCounterController();
            ActionResult indexView = controller.Index();
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void New_ReturnsCorrectView_True()
        {
            WordCounterController controller = new WordCounterController();
            ActionResult indexView = controller.New();
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        //Testing for HttpPost actions

        [TestMethod]
        public void Create_ReturnsCorrectActionType_RedirectToActionResult()
        {
            WordCounterController controller = new WordCounterController();
            IActionResult view = controller.Create("t", "t");
            Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
        }

        [TestMethod]
        public void Create_RedirectsToCorrectAction_Index()
        {
            WordCounterController controller = new WordCounterController();
            RedirectToActionResult actionResult = controller.Create("t", "t") as RedirectToActionResult;
            string result = actionResult.ActionName;
            Assert.AreEqual(result, "Index");
        }       
    }
}