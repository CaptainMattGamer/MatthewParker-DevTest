using DevTest.Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevTest.Core.Abstract
{
    public interface IUserService
    {
        User GetUser(Guid userId);

        IQueryable<User> GetAllUsers();

        User AddUser(User user);

        User UpdateUser(User user);

    }
}
