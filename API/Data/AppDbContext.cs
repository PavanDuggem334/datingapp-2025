using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class AppDbContext(DbContextOptions options) : DbContext(options: options)
{
    public DbSet<AppUser> Users { get; set; }
}
