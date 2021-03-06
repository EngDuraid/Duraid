﻿// <auto-generated />
using System;
using Duraid.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Duraid.Persistence.Migrations
{
    [DbContext(typeof(DuraidDataContext))]
    [Migration("20210123203215_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("Duraid.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("EditedByUserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EditedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Duraid.Domain.Entities.Comment", b =>
                {
                    b.Property<Guid>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CommentContent")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("EditedByUserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EditedDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PostId")
                        .HasColumnType("TEXT");

                    b.HasKey("CommentId");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Duraid.Domain.Entities.Image", b =>
                {
                    b.Property<Guid>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("EditedByUserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EditedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageDirectory")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageName")
                        .HasColumnType("TEXT");

                    b.HasKey("ImageId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("Duraid.Domain.Entities.Post", b =>
                {
                    b.Property<Guid>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("EditedByUserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EditedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostContent")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostTitle")
                        .HasColumnType("TEXT");

                    b.HasKey("PostId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Duraid.Domain.Entities.PostCategory", b =>
                {
                    b.Property<Guid>("PostCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("EditedByUserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EditedDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PostId")
                        .HasColumnType("TEXT");

                    b.HasKey("PostCategoryId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PostId");

                    b.ToTable("PostCategories");
                });

            modelBuilder.Entity("Duraid.Domain.Entities.PostImage", b =>
                {
                    b.Property<Guid>("PostImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("EditedByUserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EditedDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDefaultPostImage")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("PostId")
                        .HasColumnType("TEXT");

                    b.HasKey("PostImageId");

                    b.HasIndex("ImageId");

                    b.HasIndex("PostId");

                    b.ToTable("PostImages");
                });

            modelBuilder.Entity("Duraid.Domain.Entities.Comment", b =>
                {
                    b.HasOne("Duraid.Domain.Entities.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Duraid.Domain.Entities.PostCategory", b =>
                {
                    b.HasOne("Duraid.Domain.Entities.Category", "Category")
                        .WithMany("CategoryPosts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Duraid.Domain.Entities.Post", "Post")
                        .WithMany("PostCategories")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Duraid.Domain.Entities.PostImage", b =>
                {
                    b.HasOne("Duraid.Domain.Entities.Image", "Image")
                        .WithMany("ImagePosts")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Duraid.Domain.Entities.Post", "Post")
                        .WithMany("PostImages")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
