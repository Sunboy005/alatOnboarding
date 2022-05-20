using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model;
using System;

namespace Repository
{
    public class OnboardDbContext:IdentityDbContext
    {
        public OnboardDbContext(DbContextOptions<OnboardDbContext> options) 
            : base(options){
        }

        public DbSet<LocalGovernmentArea> LocalGovernmentAreas { get; set; }
        public DbSet<State> States { get; set; }
    }
}
