using bloodbank.Models;
using Microsoft.EntityFrameworkCore;

namespace bloodbank.Context {
    public class BloodBankContext : DbContext {
        public BloodBankContext() { }
        public BloodBankContext(DbContextOptions<BloodBankContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<BloodGroup_BloodBank>()
            .HasKey(b => new { b.BloodBankId, b.BloodGroupId });

            modelBuilder.Entity<BloodGroup_BloodBank>()
            .HasOne(b => b.BloodBank)
            .WithMany(b => b.BloodGroups_BloodBanks)
            .HasForeignKey(b => b.BloodBankId);

            modelBuilder.Entity<BloodGroup_BloodBank>()
            .HasOne(b => b.BloodGroup)
            .WithMany(b => b.BloodGroups_BloodBanks)
            .HasForeignKey(b => b.BloodGroupId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ContactInfo> ContactInfo { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<FamilyGroup> FamilyGroups { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<BloodBank> BloodBanks { get; set; }
        public DbSet<BloodGroup_BloodBank> BloodGroups_BloodBanks { get; set; }
        public DbSet<IncomingBlood> IncomingBlood { get; set; }
        public DbSet<OutgoingBlood> OutgoingBlood { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<BloodTest> BloodTests { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

    }
}