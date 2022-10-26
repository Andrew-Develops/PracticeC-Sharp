using System;

namespace ExtensionMethods
{
    public static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {
            string output = "";

            while (string.IsNullOrEmpty(output))
            {
                Console.WriteLine(message);
                output = Console.ReadLine();
            }
            return output;
        }

        public static int RequestInt(this string message, int minValue, int maxValue)
        {
            return message.RequestInt( true,0,125);
        }

        public static int RequestInt(this string message)
        {
            return message.RequestInt(false);
        }
        private static int RequestInt(this string message, bool useMinMax, int minValue = 0, int maxValue = 0)
        {
            int output = 0;
            bool isValidInt = false;
            bool isInValidRange = true;

            while (isValidInt == false || isInValidRange == false)
            {
                Console.WriteLine(message);
                isValidInt = int.TryParse(Console.ReadLine(), out output);

                if (useMinMax == true)
                {
                    isInValidRange = (output >= minValue && output <= maxValue);
                    //if (output>= minValue && output<= maxValue)
                    //{
                    //    isInValidRange = true;
                    //}
                    //else
                    //{
                    //    isInValidRange = false;
                    //}
                }
            }
            return output;
        }
    }
}


