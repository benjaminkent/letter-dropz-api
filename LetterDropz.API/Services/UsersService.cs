using System;
using System.Threading.Tasks;
using LetterDropz.API.Models;
using LetterDropz.API.Models.Users;
using LetterDropz.API.Repositories;

namespace LetterDropz.API.Services
{
    public class UsersService
    {
        private readonly DatabaseContext _dbContext;

        public UsersService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> CreateUser(UserDto userDto)
        {
            var user = userDto.ToUser();
        }
    }
}
