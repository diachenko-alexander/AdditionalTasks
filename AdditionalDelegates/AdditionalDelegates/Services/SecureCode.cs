using System;

namespace AdditionalDelegates
{
    static class SecureCode
    {
        public static int GenerateSecureCode()
        {
            Random random = new Random();
            return random.Next(1000, 9999);
        }

        public static bool CheckCode(int code, int userInput)
        {
            if (code == userInput)
            {
                return true;
            }
            return false;
        }
    }
}
