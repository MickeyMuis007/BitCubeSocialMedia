﻿// <auto-generated />
using System;
using BitCubeSocialMedia.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BitCubeSocialMedia.Persistence.Migrations
{
    [DbContext(typeof(BitCubeSocialMediaContext))]
    [Migration("20190414133540_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BitCubeSocialMedia.Domain.AggregateModels.UserAggregate.ChildEntities.Friend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("Friend1Id");

                    b.Property<Guid>("Friend2Id");

                    b.HasKey("Id");

                    b.HasAlternateKey("Friend1Id", "Friend2Id");

                    b.HasIndex("Friend2Id");

                    b.ToTable("Friend");
                });

            modelBuilder.Entity("BitCubeSocialMedia.Domain.AggregateModels.UserAggregate.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.HasAlternateKey("Email");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BitCubeSocialMedia.Domain.AggregateModels.UserAggregate.ChildEntities.Friend", b =>
                {
                    b.HasOne("BitCubeSocialMedia.Domain.AggregateModels.UserAggregate.User", "Friend1")
                        .WithMany("Friend1s")
                        .HasForeignKey("Friend1Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BitCubeSocialMedia.Domain.AggregateModels.UserAggregate.User", "Friend2")
                        .WithMany("Friend2s")
                        .HasForeignKey("Friend2Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
