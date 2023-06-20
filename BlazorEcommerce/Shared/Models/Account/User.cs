using BlazorEcommerce.Shared.Models.Account.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEcommerce.Shared.Models.Account
{
    public class User
    {
        public int Id { get; set; }
        public string GivenName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<Role> Roles { get; set; }
    }
}
