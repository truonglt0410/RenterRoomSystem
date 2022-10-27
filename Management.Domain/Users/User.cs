using Management.Domain.Base;
using Management.Domain.Departments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Management.Domain.Users
{
    [Table("Users")]
    public partial class User : DeleteEntity<int>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Id_role { get; set; }

    }
}
