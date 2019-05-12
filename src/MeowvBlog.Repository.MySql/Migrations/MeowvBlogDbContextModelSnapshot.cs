﻿// <auto-generated />
using System;
using MeowvBlog.Repository.MySql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MeowvBlog.Repository.MySql.Migrations
{
    [DbContext(typeof(MeowvBlogDbContext))]
    partial class MeowvBlogDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MeowvBlog.Models.Blog.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .IsFixedLength(true)
                        .HasMaxLength(50);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .IsFixedLength(true)
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("MeowvBlog.Models.Blog.FriendLink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LinkUrl")
                        .IsRequired()
                        .IsFixedLength(true)
                        .HasMaxLength(100);

                    b.Property<string>("Title")
                        .IsRequired()
                        .IsFixedLength(true)
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("friendlinks");
                });

            modelBuilder.Entity("MeowvBlog.Models.Blog.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abstract")
                        .IsRequired()
                        .IsFixedLength(true)
                        .HasMaxLength(200);

                    b.Property<string>("Author")
                        .IsRequired()
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreationTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Hits")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Source")
                        .IsRequired()
                        .IsFixedLength(true)
                        .HasMaxLength(20);

                    b.Property<string>("Title")
                        .IsRequired()
                        .IsFixedLength(true)
                        .HasMaxLength(100);

                    b.Property<string>("Url")
                        .IsRequired()
                        .IsFixedLength(true)
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("posts");
                });

            modelBuilder.Entity("MeowvBlog.Models.Blog.PostTag", b =>
                {
                    b.Property<int>("PostId");

                    b.Property<int>("TagId");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("post_tags");
                });

            modelBuilder.Entity("MeowvBlog.Models.Blog.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .IsFixedLength(true)
                        .HasMaxLength(50);

                    b.Property<string>("TagName")
                        .IsRequired()
                        .IsFixedLength(true)
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("tags");
                });

            modelBuilder.Entity("MeowvBlog.Models.Blog.PostTag", b =>
                {
                    b.HasOne("MeowvBlog.Models.Blog.Post", "Post")
                        .WithMany("PostTags")
                        .HasForeignKey("PostId")
                        .HasConstraintName("FK_PostTag_Post")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MeowvBlog.Models.Blog.Tag", "Tag")
                        .WithMany("PostTags")
                        .HasForeignKey("TagId")
                        .HasConstraintName("FK_PostTag_Tag")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
