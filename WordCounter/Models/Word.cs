namespace WordCounter.Models
{
    public class Word
    {
        private int _wordCount;
        private string _userWord;
        private string _userSentence;

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
            return wordCount;
        }

        public int GetWordCount()
        {
            return _wordCount;
        }

        public string GetUserWord()
        {
            return _userWord;
        }

        public string GetUserSentence()
        {
            return _userSentence;
        }
    }
}