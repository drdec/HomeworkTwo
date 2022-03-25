namespace Homework
{
    public static class InteractionWithString
    {
        public static string ReverseString(string str)
        {
            return new string(str.ToCharArray().Reverse().ToArray());
        }
    }
}
