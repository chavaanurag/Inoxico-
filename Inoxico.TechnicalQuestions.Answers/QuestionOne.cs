
namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionOne
    {
        public static int GetLongestSentance(string s)
        {
            char[] specialChar = { '.', '?' };
            string[] sentece = s.Split(specialChar);
            int lenght = sentece.GetLength();
            int maxCount = 0;

            for (int i = lenght - 1; i >= 0; i--)
            {
                string[] words = sentece[i].Split(' ');
                int wordCount = words.GetLength();
                if (maxCount < wordCount)
                {
                    maxCount = wordCount;
                }
            }

            return maxCount;


            // throw new NotImplementedException();
        }
    }
}




