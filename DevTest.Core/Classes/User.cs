using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DevTest.Core.Classes
{
    public class User
    {
        public Guid UserId { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        [MaxLength(3)]
        public string Title { get; set; }

        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [DataType(DataType.Text)]
        public string Password { get; set; }
    }
}
