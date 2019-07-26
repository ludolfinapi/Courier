using System;
using System.Collections.Generic;
using System.Text;

namespace Courier.core.Domain
{
    public class User
    {
        public Guid  Id { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public string FullNname { get; protected set; }
        public string Username { get; protected set; }
        public DateTime CreatedAt { get; protected  set; }

        protected User()
        {
        }

        public User(Guid userId, string email, string fullName, string username,  string password )
        {
            Id = userId;
            Email = email;
            FullName = fullName;
            Username = username;
            CreatedAt = DateTime.Utc;
            


        }

    }
}
 