﻿// <auto-generated />
using System;
using IELTSRegistrationEF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IELTSRegistrationEF.Migrations
{
    [DbContext(typeof(IELTSRegistrationEFContext))]
    [Migration("20210304013354_ADDRESULT")]
    partial class ADDRESULT
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IELTSRegistrationEF.Model.Booking", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Fee")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegistrationID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RegistrationID");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("IELTSRegistrationEF.Model.Registration", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Category")
                        .HasColumnType("int");

                    b.Property<int>("Contact")
                        .HasColumnType("int");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TestType")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Registration");
                });

            modelBuilder.Entity("IELTSRegistrationEF.Model.Result", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Band")
                        .HasColumnType("int");

                    b.Property<int>("BookingID")
                        .HasColumnType("int");

                    b.Property<int>("RegistrationID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RegistrationID");

                    b.ToTable("Result");
                });

            modelBuilder.Entity("IELTSRegistrationEF.Model.Booking", b =>
                {
                    b.HasOne("IELTSRegistrationEF.Model.Registration", "Registration")
                        .WithMany("Bookings")
                        .HasForeignKey("RegistrationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Registration");
                });

            modelBuilder.Entity("IELTSRegistrationEF.Model.Result", b =>
                {
                    b.HasOne("IELTSRegistrationEF.Model.Registration", "Registration")
                        .WithMany("Results")
                        .HasForeignKey("RegistrationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Registration");
                });

            modelBuilder.Entity("IELTSRegistrationEF.Model.Registration", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Results");
                });
#pragma warning restore 612, 618
        }
    }
}
