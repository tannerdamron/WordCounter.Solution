namespace WordCounter
{
    public class Word
    {
        public int _wordCount;
        public string _userWord;
        public string _userSentence;

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
    }
}