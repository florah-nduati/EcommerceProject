using ShoppingCart.Domain.Entities;
using ShoppingCart.Domain.EntityIds;
using ShoppingCart.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Domain.Abstractions.Repositories
{
    public interface IUserRepository
    {
        void Add(User user);
        void Update(User user);
        Task<User?> GetByIdAsync(UserId id, CancellationToken cancellationToken);
        Task<User?> GetByEmailAsync(Email email,  CancellationToken cancellationToken);
        Task<User?> GetByUsernameAsync(Username username, CancellationToken cancellationToken);
        Task<bool> IsEmailUniqueAsync(Email email, CancellationToken cancellationToken);
        Task<bool> IsEmailTakenAsync(Email email, CancellationToken cancellationToken);
    }
}
