namespace WordCounter
{
    public class Word
    {
        public bool IsMatch(string userWord, string userSentence)
        {
            if (userWord == userSentence)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}