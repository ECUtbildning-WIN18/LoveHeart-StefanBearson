namespace LoveHeart.Domain
{
    class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }

        public User(string userName, string password, string userRole)
        {
            UserName = userName;
            Password = password;
            UserRole = userRole; //vet, rec, admin
        }
    }
}
