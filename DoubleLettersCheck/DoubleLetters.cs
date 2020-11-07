namespace DoubleLettersCheck

// task: https://edabit.com/challenge/ugg9ZK7xY5vk5qJXr

{
    public class DoubleLetters
    {
        public static bool HasConsequtiveLetters(string text, int sequence)
        {
            for (int i = 0; i < text.Length - sequence; i++)
            {
                var success = true;
                var nextIndex = 0;
                for (int j = 1; j < sequence; j++)
                {
                    if (text[i] != text[i+j])
                    {
                        nextIndex = i+j-1;
                        success = false;
                        break;
                    }
                }
                if (success) {return success;}
                i = nextIndex;
            }
            return false;
        }
    }
}