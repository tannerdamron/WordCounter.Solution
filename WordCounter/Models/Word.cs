namespace WordCounter.Models
{
    public class Word
    {
        private static int _wordCount;
        private static string _userWord;
        private static string _userSentence;

        public Word(int wordCount, string userWord, string userSentence)
        {
            _wordCount = wordCount;
            _userWord = userWord;
            _userSentence = userSentence;
        }

        public int MatchCounter(int wordCount, string userWord, string userSentence)
        {
            string[] splitWords = userSentence.Split(' ');
            foreach (var singleWord in splitWords)
            {
                if (userWord == singleWord)
                {
                    wordCount++;
                }
            }
            _wordCount = wordCount;
            return _wordCount;
        }

        public static int GetWordCount()
        {
            return _wordCount;
        }

        public static string GetUserWord()
        {
            return _userWord;
        }

        public static string GetUserSentence()
        {
            return _userSentence;
        }
    }
}