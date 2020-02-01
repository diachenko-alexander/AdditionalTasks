namespace AdditionalDelegates
{
    class User
    {
        public string UserName { get; set; }
        public string UserPhone { get; set; }

        public User(string userName, string userPhone)
        {
            UserName = userName;
            UserPhone = userPhone;
        }
    }
}
