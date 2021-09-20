using bloodbank.Models;
using Microsoft.EntityFrameworkCore;

namespace bloodbank.Context {
    public class BloodBankContext : DbContext {
        public BloodBankContext() { }
        public BloodBankContext(DbContextOptions<BloodBankContext> options) : base(options) { }
        public DbSet<ContactInfo> ContactInfo { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<FamilyGroup> FamilyGroups { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<BloodBank> BloodBanks { get; set; }
        public DbSet<IncomingBlood> IncomingBlood { get; set; }
        public DbSet<OutgoingBlood> OutgoingBlood { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Donor> Donor { get; set; }
        public DbSet<BloodTest> BloodTests { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<bloodbank.Models.Role> Role { get; set; }
    }
}