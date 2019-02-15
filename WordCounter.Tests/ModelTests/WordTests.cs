using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordTests
    {
        [TestMethod]
        public void MatchCounter_IsOneLetterMatchToOneLetterSentence_1()
        {
            int wordCount = 0;
            string testUserWord = "t";
            string testUserSentence = "i saw a t and shit my pants";
            Word testWord = new Word(wordCount, testUserWord, testUserSentence);
            Assert.AreEqual(4, testWord.MatchCounter(wordCount, testUserWord, testUserSentence));
        }
    }
}