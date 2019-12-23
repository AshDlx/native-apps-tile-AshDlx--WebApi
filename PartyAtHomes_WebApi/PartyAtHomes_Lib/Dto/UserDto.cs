using System;

namespace PartyAtHomes_Lib
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
    }

    public class LoginDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class RegisterDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
