﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Models;

namespace TechShop
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Partner> Partners { get; set; }

        internal object Where()
        {
            throw new NotImplementedException();
        }

        public DbSet<Setting> Settings { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<MessageContact> MessageContacts { get; set; }

    }
}
