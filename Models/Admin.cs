﻿using System;
using System.Collections.Generic;

namespace Assignment_AuthenticationDB.Models
{
    public partial class Admin
    {
        public int AdminId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Role { get; set; } = null!;
        public DateTime JoinDate { get; set; }
    }
}
