using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string answer = "";
            for (var i = 0; i < original.Length; i++)
            {
                answer += original[i].ToString() + original[i].ToString();
            }
            return answer;
        }
    }
}
