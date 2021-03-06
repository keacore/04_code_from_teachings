﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ConsoleApplication.Models;

namespace _04_code_from_teachings.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20170309144550_third")]
    partial class third
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("ConsoleApplication.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<DateTime>("EnrollmenDate");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });
        }
    }
}
