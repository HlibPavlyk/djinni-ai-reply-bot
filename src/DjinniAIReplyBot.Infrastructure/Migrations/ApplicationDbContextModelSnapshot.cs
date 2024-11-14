﻿// <auto-generated />
using DjinniAIReplyBot.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DjinniAIReplyBot.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DjinniAIReplyBot.Domain.Entities.UserConfiguration", b =>
                {
                    b.Property<long>("ChatId")
                        .HasColumnType("bigint")
                        .HasColumnName("chat_id");

                    b.Property<string>("AdditionalConfiguration")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("additional_configuration");

                    b.Property<bool>("IsAccepted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("is_accepted");

                    b.Property<string>("ParsedResume")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("parsed_resume");

                    b.Property<string>("ReplyLanguage")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)")
                        .HasDefaultValue("En")
                        .HasColumnName("reply_language");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("username");

                    b.HasKey("ChatId");

                    b.HasIndex("ChatId")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("user_configurations", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
