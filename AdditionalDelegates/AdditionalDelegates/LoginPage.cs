using System;
using System.Threading;

namespace AdditionalDelegates

{

    delegate void SmsDelegate(string message);
    delegate int GetSecureCode();
    delegate bool CheckSecureCode(int code, int userInput);

    class LoginPage
    {


        User user = null;
        public void GetUserData(int attempt)
        {
            for (int i = 0; i < attempt; i++)
            {
                Console.Write("User name: ");
                string userName = Console.ReadLine();

                Console.Write("Phone number: ");
                string userPhone = Console.ReadLine();

                if (UserDataValidator.UserNameValidator(userName) && UserDataValidator.UserPhoneValidator(userPhone))
                {
                    user = new User(userName, userPhone);
                    return;
                }

                if (i == attempt - 1)
                {
                    Console.WriteLine("You entered incorect data 3 times. Please close program and retry");
                    return;
                }

                Console.WriteLine("Incorect Data.\nWait 5 seconds and enter correct data");
                Thread.Sleep(5000);
                Console.Clear();
            }


        }

        public void VerifyUserBySms(int attempt)
        {
            if (user != null)
            {
                SmsDelegate sendSms = new SmsDelegate(SmsService.sendSMSMessage);
                GetSecureCode getSecureCode = new GetSecureCode(SecureCode.GenerateSecureCode);
                CheckSecureCode checkSecureCode = new CheckSecureCode(SecureCode.CheckCode);

                int verificationCode = getSecureCode();

                Console.WriteLine("SMS sent");
                sendSms($"User {user.UserName} with number {user.UserPhone}, your code is {verificationCode}");

                for (int i = attempt; i > 0; i--)
                {


                    Console.Write("Verification code: ");
                    int userInputCode = int.Parse(Console.ReadLine());

                    if (!checkSecureCode(verificationCode, userInputCode))
                    {
                        Console.WriteLine($"Invalid code, {i-1} attempts left");
                    }
                    else
                    {
                        Console.WriteLine($"Welcome {user.UserName}");
                        return;
                    }

                }

                return;

            }






        }
    }
}
