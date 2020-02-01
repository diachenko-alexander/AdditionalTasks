namespace AdditionalDelegates
{
    static class UserDataValidator
    {
        public static bool UserNameValidator(string userName)
        {
            if (userName.Trim().Length > 0)
            {
                return true;
            }
            return false;
        }

        public static bool UserPhoneValidator(string userPhone)
        {
            if (userPhone.Trim().StartsWith("+380") && userPhone.Length == 13)
            {
                return true;
            }
            return false;
        }
    }
}
