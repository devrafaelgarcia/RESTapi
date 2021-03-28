using Primeiro.ApiWeb.Data.VO;
using Primeiro.ApiWeb.Models;
using Primeiro.ApiWeb.Models.Context;
using Primeiro.ApiWeb.Services.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro.ApiWeb.Services.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ContextMySql _context;

        public UserRepository(ContextMySql context)
        {
            _context = context;
        }

        public User ValidateCredentials(UserVO user)
        {

            var pass = ComputeHash(user.Password, new SHA256CryptoServiceProvider());
            return _context.Users.FirstOrDefault(u => (u.UserName == user.UserName) && (u.Password == pass));
        }


        public User RefrashUserInfo(User user)
        {
            if (!_context.Users.Any(p => p.Id.Equals(user.Id))) return null;
          
        
            var result = _context.Users.SingleOrDefault(x => x.Id.Equals(user.Id));

            if (result != null)
            {

                try
                {
                    _context.Entry(result).CurrentValues.SetValues(user);
                    _context.SaveChanges();
                    return result;
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
           return result;

        }



        private string ComputeHash(string input, SHA256CryptoServiceProvider algorithm)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }
    }
}
