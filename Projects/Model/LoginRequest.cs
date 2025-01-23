﻿namespace Projects.Model
{
    public class LoginRequest
    {
        public LoginRequest()
        {
            
        }
        public LoginRequest(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public string Email { get; private set; }
        public string Password { get; private set; }
    }
}
