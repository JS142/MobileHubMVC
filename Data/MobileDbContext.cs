using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MobileHubMVC.Models;

namespace MobileHubMVC.Data
{
    public class MobileDbContext : IdentityDbContext
    {
        public MobileDbContext(DbContextOptions<MobileDbContext> options)
            : base(options)
        {
        }
        public DbSet<MobileHubMVC.Models.Mobile> Mobile { get; set; }
        public DbSet<MobileHubMVC.Models.Order> Order { get; set; }
        public DbSet<MobileHubMVC.Models.User> User { get; set; }
    }


}
