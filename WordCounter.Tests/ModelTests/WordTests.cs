using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordTests
    {
        [TestMethod]
        public void IsMatch_IsOneLetterMatchToOneLetterSentence_True()
        {
            Word testWord = new Word();
            Assert.AreEqual(true, testWord.IsMatch("t"));
        }
    }
}