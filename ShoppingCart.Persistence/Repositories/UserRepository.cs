using Microsoft.EntityFrameworkCore;
using ShoppingCart.Domain.Abstractions.Repositories;
using ShoppingCart.Domain.Entities;
using ShoppingCart.Domain.EntityIds;
using ShoppingCart.Domain.ValueObjects;
using ShoppingCart.Persistence.Frameworks;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ShoppingCart.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ShoppingCartContext _context;
    
        public UserRepository (ShoppingCartContext context)
        {
            _context = context;
        }
        public void Add(User user)
        {
           _context.Set<User>().Add(user);
        }

        public async Task<User?> GetByEmailAsync(Email email, CancellationToken cancellationToken)
        {
            return await _context.Set<User>().Where(user => user.Email == email).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<User?> GetByIdAsync(UserId id, CancellationToken cancellationToken)
        {
            return await _context.Set<User>().Where(user=>user.Id == id).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<User?> GetByUsernameAsync(Username username, CancellationToken cancellationToken)
        {
            return await _context.Set<User>().Where(user => user.Username == username).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<bool> IsEmailTakenAsync(Email email, CancellationToken cancellationToken)
        {
            return await _context.Set<User>().Where(user => user.Email== email).AnyAsync(cancellationToken);
        }

        public async Task<bool> IsEmailUniqueAsync(Email email, CancellationToken cancellationToken)
        {
            return await IsEmailTakenAsync(email, cancellationToken) is false;
        }

        public void Update(User user)
        {
            _context.Set<User>().Update(user);
        }
    }
}
