using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class WordCounterController : Controller
    {
        [HttpGet("/count")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost("/count")]
        public ActionResult Create(int wordCount, string userWord, string userSentence)
        {
            Word newWord = new Word(wordCount, userWord, userSentence);
            return RedirectToAction("Index");
        }

        [HttpGet("/count/new")]
        public ActionResult New()
        {
            return View();
        }      
    }
}