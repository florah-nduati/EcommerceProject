using ShoppingCart.Domain.EntityIds;
using ShoppingCart.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Domain.Entities
{
    public sealed class User
    {
        public string Username Username{ get; set; }
        public string Email Email{ get; set; }
        public string PasswordHash PasswordHash { get; set; }
        private User(UserId id,Username username, Email email) { }
        public static User Create (UserId id,Username username, Email email)
        {
            var user = new User(id, username, email);
            return user;

        }
    }

}
