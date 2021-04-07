using DevTest.Core.Abstract;
using DevTest.Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevTest.Core.Services
{
    public class UserService : IUserService
    {
        //Lets pretend that all this data is in a database somewhere
        private static List<User> testusers = new List<User> {
                new User { Email = "andrew@testsite.com", FirstName = "Andrew", LastName = "Wilson", Password = "cbrg4534", Title = "Mr", UserId = Guid.Parse("06e72ae4-b2dd-487f-aa15-4f5c65878f4d"), UserName =  "awilson"  },
                new User { Email = "james@testsite.com", FirstName = "James", LastName = "Thomas", Password = "dfgdsfbn ", Title = "Mrs", UserId = Guid.Parse("1fa4b02d-4db1-4996-a761-a266b3388ed1"), UserName =  "jt"  },
                new User { Email = "lucy@testsite.com", FirstName = "Lucy", LastName = "Rogerson", Password = "hgfhvcxb", Title = "Mr", UserId = Guid.Parse("055e30aa-ee6b-47c8-ae94-f3101a26805d"), UserName =  "lucyrogerson"  },
                new User { Email = "dimi@testsite.com", FirstName = "Dimitrios", LastName = "Konstantopoulos", Password = "cvxbxc", Title = "Mr", UserId = Guid.Parse("ec9077e1-65c5-40bc-9ddc-ef6b979790e5"), UserName =  "no1"  },
                new User { Email = "raj@testsite.com", FirstName = "Raj", LastName = "Singh", Password = "45fgsdg", Title = "Mr", UserId = Guid.Parse("5f459bcb-3fd1-4fce-9cf9-a6b7de6bc8dd"), UserName =  "rsingh"  },
                new User { Email = "sheena@testsite.com", FirstName = "Sheena", LastName = "Sea", Password = "dfsgsdf3465", Title = "Mr", UserId = Guid.Parse("5dfb5176-3d8b-44c9-84a5-52a328bb2cec"), UserName =  "ss"  },
                new User { Email = "mike@testsite.com", FirstName = "Michael", LastName = "O'Neal", Password = "dsfgsdgxcvb", Title = "Dr", UserId = Guid.Parse("2ad741c4-90b3-41a8-adb2-8771e5be6e3d"), UserName =  "mike"  },
                new User { Email = "mindi@testsite.com", FirstName = "Mindi", LastName = "Kee", Password = "cvbcjyhhgf", Title = "Mr", UserId = Guid.Parse("20c65656-5dc5-4fc7-a24d-e722bdc1bb0e"), UserName =  "mindii"  },
                new User { Email = "stewart@testsite.com", FirstName = "Stew", LastName = "Pickering", Password = "hgjfe6u", Title = "Mr", UserId = Guid.Parse("a606449a-7d68-4550-83fd-09973a5c8786"), UserName =  "stew"  },
                new User { Email = "colin@testsite.com", FirstName = "Colin", LastName = "Moroz", Password = "cxvrdsyt354", Title = "Mr", UserId = Guid.Parse("5dd9a4a5-6b2b-4a0b-bca3-8af7ead6bfd2"), UserName =  "moroz"  },
                new User { Email = "justine@testsite.com", FirstName = "Justine", LastName = "Chapman", Password = "nvb63jy", Title = "M", UserId = Guid.Parse("a03c6bce-6a55-4809-9782-ee9b0c879ca9"), UserName =  "juschap"  },
                new User { Email = "daniel@testsite.com", FirstName = "Daniel", LastName = "Everitt", Password = "jytj26", Title = "Mr", UserId = Guid.Parse("64b1e349-5760-4afa-b220-a50e4811bd11"), UserName =  "dannyboy"  },
                new User { Email = "emily@testsite.com", FirstName = "Emily", LastName = "Lodge", Password = "vbcert6754", Title = "Miss", UserId = Guid.Parse("4ebba298-e5bb-4049-b276-6aec908d744f"), UserName =  "em"  },
            };

        public User AddUser(User user)
        {
            testusers.Add(user);
            return user;
        }


        public IQueryable<User> GetAllUsers()
        {
            //In a proper application this data would be coming from the database. Lets pretend that it is.

            return testusers.AsQueryable();

        }


        public User GetUser(Guid userId)
        {
            return testusers.SingleOrDefault(e => e.UserId == userId);
        }

        public User UpdateUser(User user)
        {
            User updateUser = GetUser(user.UserId);
            
            updateUser.UserName = user.UserName;
            updateUser.Title = user.Title;
            updateUser.FirstName = user.FirstName;
            updateUser.LastName = user.LastName;
            updateUser.Email = user.Email;

            return updateUser;
        }
    }
}