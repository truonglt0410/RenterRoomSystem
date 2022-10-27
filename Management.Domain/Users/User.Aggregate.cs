using Management.Domain.Departments;
using System.ComponentModel.DataAnnotations;

namespace Management.Domain.Users
{
    public partial class User
    {
        string userName { get; set; }
        string password { get; set; }
        string email { get; set; }
        int id_role { get; set; }

        public bool ValidOnAdd()
        {
            return
                // Validate userName
                !string.IsNullOrEmpty(UserName)
                // Make sure email not null and correct email format
                && !string.IsNullOrEmpty(Email)
                && new EmailAddressAttribute().IsValid(Email);
                
            // Make sure department not null

        }
    }
}
