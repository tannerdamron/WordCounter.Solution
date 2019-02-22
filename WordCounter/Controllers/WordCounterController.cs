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
        public ActionResult Create(string userWord, string userSentence)
        {
            int wordCount = 0;
            Word newWord = new Word(wordCount, userWord, userSentence);
            newWord.MatchCounter(wordCount, userWord, userSentence);
            return RedirectToAction("Index", newWord);
        }

        [HttpGet("/count/new")]
        public ActionResult New()
        {
            return View();
        }      
    }
}