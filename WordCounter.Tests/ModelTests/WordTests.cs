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
            string testUserSentence = "t";
            Word testWord = new Word(wordCount, testUserWord, testUserSentence);
            Assert.AreEqual(1, testWord.MatchCounter(wordCount, testUserWord, testUserSentence));
        }
        [TestMethod]
        public void MatchCounter_IsOneLetterMatchToTwoOneLetterSentences_2()
        {
            int wordCount = 0;
            string testUserWord = "t";
            string testUserSentence = "t t";
            Word testWord = new Word(wordCount, testUserWord, testUserSentence);
            Assert.AreEqual(2, testWord.MatchCounter(wordCount, testUserWord, testUserSentence));
        }
        [TestMethod]
        public void MatchCounter_IsOneLetterMatchToOneLetterInLongSentence_1()
        {
            int wordCount = 0;
            string testUserWord = "t";
            string testUserSentence = "I saw a t and I didn't know it was there";
            Word testWord = new Word(wordCount, testUserWord, testUserSentence);
            Assert.AreEqual(1, testWord.MatchCounter(wordCount, testUserWord, testUserSentence));
        }
        [TestMethod]
        public void MatchCounter_IsOneLetterMatchToMultiplesOfLetterInLongSentence_2()
        {
            int wordCount = 0;
            string testUserWord = "t";
            string testUserSentence = "I saw a t and ate a t";
            Word testWord = new Word(wordCount, testUserWord, testUserSentence);
            Assert.AreEqual(2, testWord.MatchCounter(wordCount, testUserWord, testUserSentence));
        }
        [TestMethod]
        public void MatchCounter_IsUserWordMatchToWordsInLongSentence_1()
        {
            int wordCount = 0;
            string testUserWord = "cat";
            string testUserSentence = "I saw a cat";
            Word testWord = new Word(wordCount, testUserWord, testUserSentence);
            Assert.AreEqual(1, testWord.MatchCounter(wordCount, testUserWord, testUserSentence));
        }
        [TestMethod]
        public void MatchCounter_IsUserWordMatchToMultipleWordsInLongSentence_2()
        {
            int wordCount = 0;
            string testUserWord = "cat";
            string testUserSentence = "I saw a cat and that cat was fat";
            Word testWord = new Word(wordCount, testUserWord, testUserSentence);
            Assert.AreEqual(2, testWord.MatchCounter(wordCount, testUserWord, testUserSentence));
        }
        [TestMethod]
        public void MatchCounter_IsUserWordMatchToMultipleWordsInLongSentenceButNotBeginningsOfWords_2()
        {
            int wordCount = 0;
            string testUserWord = "cat";
            string testUserSentence = "I saw a cat cathedral and that cat cathedral was fat";
            Word testWord = new Word(wordCount, testUserWord, testUserSentence);
            Assert.AreEqual(2, testWord.MatchCounter(wordCount, testUserWord, testUserSentence));
        }
    }
}