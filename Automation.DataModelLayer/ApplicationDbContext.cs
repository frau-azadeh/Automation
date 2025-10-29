using Automation.DataModelLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation.DataModelLayer
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUsers,ApplicationRoles,string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(option)
        {

        }
    }
}
