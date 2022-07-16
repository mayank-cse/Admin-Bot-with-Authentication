using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceAdminBot.Models
{
    public class UserProfile
    {
        public bool UserAuthenticated { get; set; } = false;
        public int OTP { get; set; }
        public string ValueFinder { get; set; }
    }
}
