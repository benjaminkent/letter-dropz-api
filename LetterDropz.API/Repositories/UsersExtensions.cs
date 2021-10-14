using System;
using LetterDropz.API.Models.Users;

namespace LetterDropz.API.Repositories
{
    public static class UsersExtensions
    {
        public static User Create(this UserDto userDto)
        {
            return new User()
            {
                Username = userDto.Username,
                Email = userDto.Email,
                Password = userDto.Password,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                IsAdmin = false
            };
        }
    }
}
