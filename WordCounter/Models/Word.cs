namespace WordCounter
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
                else
                {
                    
                }
            }
            return wordCount;
        }
    }
}