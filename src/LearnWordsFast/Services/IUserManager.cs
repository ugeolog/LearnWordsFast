﻿using System;
using System.Threading.Tasks;
using LearnWordsFast.DAL.Models;
using Microsoft.AspNet.Identity;

namespace LearnWordsFast.Services
{
    public interface IUserManager
    {
        Task<IdentityResult> CreateAsync(User user, string password);

        Task<IdentityResult> ChangePasswordAsync(User user, string currentPassword, string newPassword);

        Task<User> FindById(Guid id);

        Task<IdentityResult> UpdateAsync(User user);
    }
}