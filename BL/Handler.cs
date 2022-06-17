using System;

namespace BL
{
    public class Handler
    {
        public string DetermineNumber(int number)
        {
            switch (number)
            {
                case int i when i < 0:
                    return "negative";
                case int i when i > 0:
                    return "positive";
                default:
                    return "zero";
            }
        }
    }
}
