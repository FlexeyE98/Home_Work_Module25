using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Repositories
{
    public class UserRepository
    {
        private AppContext _context;

        public void FindUserByID()
        {
            _context.Users.FirstOrDefault();
        
        }

        public void FindAllUsers()
        {
            _context.Users.ToList();
        
        }

        public void AddUser(User user)
        { 
            _context.Users.Add(user);
        
        }

        public void DeleteUser(User user) 
        {
            _context.Users.Remove(user);
        }

        public void UpdateUserName(int id, string name) 
        {
            _context.Users.FirstOrDefault().Name = name;
        
        }
    }
}
