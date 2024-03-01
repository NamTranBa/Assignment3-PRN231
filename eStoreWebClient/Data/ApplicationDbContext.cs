using BusinessObject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eStoreWebClient.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Cấu hình quan hệ giữa ApplicationUser và Order
            builder.Entity<Order>()
                .HasOne<ApplicationUser>(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.MemberId);
        }
    }
}
