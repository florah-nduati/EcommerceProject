using ShoppingCart.Domain.EntityIds;
using ShoppingCart.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Domain.Entities
{
    public sealed class User
    {
        public UserId Id { get; private set; }
        public Username Username{ get; private set; }
        public  Email Email{ get; set; }
        public  PasswordHash PasswordHash { get; set; }
        private User(UserId id,Username username, Email email, PasswordHash passwordHash) 
        {
            Id = id;
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
        }
        public static User Create (UserId id,Username username, Email email, PasswordHash passwordHash)
        {
            var user = new User(id, username, email, passwordHash);
            return user;

        }
    }

}
