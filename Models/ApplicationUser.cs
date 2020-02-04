using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppProject.Models
{
    public class ApplicationUser:IdentityUser

    {
        //Adding new mebership details
        public string First_Name { get; set; }

        public string Last_Name { get; set; }
        public DateTime? DOB { get; set; }

        public string Membership_Type { get; set; }

    }
}
