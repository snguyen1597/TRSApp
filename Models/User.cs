﻿namespace TRSApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }  // E.g., Admin, User, etc.
    }
}
