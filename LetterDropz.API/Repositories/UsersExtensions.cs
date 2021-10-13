using System;
using LetterDropz.API.Models.Users;

namespace LetterDropz.API.Repositories
{
    public static class UsersExtensions
    {
        public static User ToUser(this UserDto userDto)
        {
            return new User()
            {
                UserName = userDto.UserName,
                Email = userDto.Email,
                Password = userDto.Password,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                IsAdmin = false
            };
        }
    }
}
