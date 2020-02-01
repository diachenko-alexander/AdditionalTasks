namespace AdditionalDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.GetUserData(3);
            loginPage.VerifyUserBySms(3);
        }
    }
}
