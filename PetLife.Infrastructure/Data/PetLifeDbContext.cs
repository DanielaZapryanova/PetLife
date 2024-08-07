﻿using Microsoft.EntityFrameworkCore;
using PetLife.Infrastructure.Data.Models;

namespace PetLife.Infrastructure.Data
{
    public class PetLifeDbContext : DbContext
    {
        public PetLifeDbContext()
        {
        }

        public PetLifeDbContext(DbContextOptions<PetLifeDbContext> options) : base(options)
        {
        }

        public DbSet<Test> Tests { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        public DbSet<Vaccination> Vaccinations { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<AnimalType> AnimalTypes { get; set; }
        public DbSet<Deworming> Dewormings { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Animal> Animals { get; set; }
    }
}
