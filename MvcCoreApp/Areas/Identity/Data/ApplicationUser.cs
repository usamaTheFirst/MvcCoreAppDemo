using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MvcCoreApp.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [PersonalData]
    public String  FirstName { get; set; }
    [PersonalData]
    public String LastName { get; set; }
    [PersonalData]
    public int Pno { get; set; }
    [PersonalData]
    public String Designation { get; set; }
    [PersonalData]
    public String Department { get; set; }
}

