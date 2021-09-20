﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bloodbank.Context;

namespace bloodbank.Migrations
{
    [DbContext(typeof(BloodBankContext))]
    [Migration("20210920062308_ContactInfo_Refactor")]
    partial class ContactInfo_Refactor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("bloodbank.Models.BloodBank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactInfoId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ContactInfoId");

                    b.ToTable("BloodBanks");
                });

            modelBuilder.Entity("bloodbank.Models.BloodGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BloodBankId")
                        .HasColumnType("int");

                    b.Property<string>("BloodType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("RH")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("Id");

                    b.HasIndex("BloodBankId");

                    b.ToTable("BloodGroups");
                });

            modelBuilder.Entity("bloodbank.Models.BloodTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DonorId")
                        .HasColumnType("int");

                    b.Property<string>("TestResults")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DonorId");

                    b.ToTable("BloodTests");
                });

            modelBuilder.Entity("bloodbank.Models.ContactInfo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactInfo");
                });

            modelBuilder.Entity("bloodbank.Models.Disease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Diseases");
                });

            modelBuilder.Entity("bloodbank.Models.Donor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BloodGroupId")
                        .HasColumnType("int");

                    b.Property<string>("ContactInfoId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("FamilyGroupId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BloodGroupId");

                    b.HasIndex("ContactInfoId");

                    b.HasIndex("FamilyGroupId");

                    b.ToTable("Donor");
                });

            modelBuilder.Entity("bloodbank.Models.FamilyGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FamilyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FamilyGroups");
                });

            modelBuilder.Entity("bloodbank.Models.Hospital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactInfoId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactInfoId");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("bloodbank.Models.IncomingBlood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BloodTestId")
                        .HasColumnType("int");

                    b.Property<int?>("DonorId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BloodTestId");

                    b.HasIndex("DonorId");

                    b.ToTable("IncomingBlood");
                });

            modelBuilder.Entity("bloodbank.Models.OutgoingBlood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HospitalId")
                        .HasColumnType("int");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HospitalId");

                    b.HasIndex("PatientId");

                    b.ToTable("OutgoingBlood");
                });

            modelBuilder.Entity("bloodbank.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BloodGroupId")
                        .HasColumnType("int");

                    b.Property<string>("ContactInfoId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("DiseaseId")
                        .HasColumnType("int");

                    b.Property<int?>("FamilyGroupId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BloodGroupId");

                    b.HasIndex("ContactInfoId");

                    b.HasIndex("DiseaseId");

                    b.HasIndex("FamilyGroupId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("bloodbank.Models.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int?>("BloodGroupId")
                        .HasColumnType("int");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BloodGroupId");

                    b.HasIndex("PatientId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("bloodbank.Models.BloodBank", b =>
                {
                    b.HasOne("bloodbank.Models.ContactInfo", "ContactInfo")
                        .WithMany()
                        .HasForeignKey("ContactInfoId");

                    b.Navigation("ContactInfo");
                });

            modelBuilder.Entity("bloodbank.Models.BloodGroup", b =>
                {
                    b.HasOne("bloodbank.Models.BloodBank", "BloodBank")
                        .WithMany()
                        .HasForeignKey("BloodBankId");

                    b.Navigation("BloodBank");
                });

            modelBuilder.Entity("bloodbank.Models.BloodTest", b =>
                {
                    b.HasOne("bloodbank.Models.Donor", "Donor")
                        .WithMany()
                        .HasForeignKey("DonorId");

                    b.Navigation("Donor");
                });

            modelBuilder.Entity("bloodbank.Models.Donor", b =>
                {
                    b.HasOne("bloodbank.Models.BloodGroup", "BloodGroup")
                        .WithMany()
                        .HasForeignKey("BloodGroupId");

                    b.HasOne("bloodbank.Models.ContactInfo", "ContactInfo")
                        .WithMany()
                        .HasForeignKey("ContactInfoId");

                    b.HasOne("bloodbank.Models.FamilyGroup", "FamilyGroup")
                        .WithMany()
                        .HasForeignKey("FamilyGroupId");

                    b.Navigation("BloodGroup");

                    b.Navigation("ContactInfo");

                    b.Navigation("FamilyGroup");
                });

            modelBuilder.Entity("bloodbank.Models.Hospital", b =>
                {
                    b.HasOne("bloodbank.Models.ContactInfo", "ContactInfo")
                        .WithMany()
                        .HasForeignKey("ContactInfoId");

                    b.Navigation("ContactInfo");
                });

            modelBuilder.Entity("bloodbank.Models.IncomingBlood", b =>
                {
                    b.HasOne("bloodbank.Models.BloodTest", "BloodTest")
                        .WithMany()
                        .HasForeignKey("BloodTestId");

                    b.HasOne("bloodbank.Models.Donor", "Donor")
                        .WithMany()
                        .HasForeignKey("DonorId");

                    b.Navigation("BloodTest");

                    b.Navigation("Donor");
                });

            modelBuilder.Entity("bloodbank.Models.OutgoingBlood", b =>
                {
                    b.HasOne("bloodbank.Models.Hospital", "Hospital")
                        .WithMany()
                        .HasForeignKey("HospitalId");

                    b.HasOne("bloodbank.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");

                    b.Navigation("Hospital");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("bloodbank.Models.Patient", b =>
                {
                    b.HasOne("bloodbank.Models.BloodGroup", "BloodGroup")
                        .WithMany()
                        .HasForeignKey("BloodGroupId");

                    b.HasOne("bloodbank.Models.ContactInfo", "ContactInfo")
                        .WithMany()
                        .HasForeignKey("ContactInfoId");

                    b.HasOne("bloodbank.Models.Disease", "Disease")
                        .WithMany()
                        .HasForeignKey("DiseaseId");

                    b.HasOne("bloodbank.Models.FamilyGroup", "FamilyGroup")
                        .WithMany()
                        .HasForeignKey("FamilyGroupId");

                    b.Navigation("BloodGroup");

                    b.Navigation("ContactInfo");

                    b.Navigation("Disease");

                    b.Navigation("FamilyGroup");
                });

            modelBuilder.Entity("bloodbank.Models.Request", b =>
                {
                    b.HasOne("bloodbank.Models.BloodGroup", "BloodGroup")
                        .WithMany()
                        .HasForeignKey("BloodGroupId");

                    b.HasOne("bloodbank.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");

                    b.Navigation("BloodGroup");

                    b.Navigation("Patient");
                });
#pragma warning restore 612, 618
        }
    }
}
