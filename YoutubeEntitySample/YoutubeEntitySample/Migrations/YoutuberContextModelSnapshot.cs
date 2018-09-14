﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YoutubeEntitySample.Models;

namespace YoutubeEntitySample.Migrations
{
    [DbContext(typeof(YoutuberContext))]
    partial class YoutuberContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview1-35029")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YoutubeEntitySample.Models.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Duration");

                    b.Property<string>("Url");

                    b.Property<int>("YoutuberId");

                    b.HasKey("Id");

                    b.HasIndex("YoutuberId")
                        .IsUnique();

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("YoutubeEntitySample.Models.Youtuber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChannelName");

                    b.Property<int>("SubscriberCount");

                    b.HasKey("Id");

                    b.ToTable("Youtubers");
                });

            modelBuilder.Entity("YoutubeEntitySample.Models.Video", b =>
                {
                    b.HasOne("YoutubeEntitySample.Models.Youtuber")
                        .WithOne("Videos")
                        .HasForeignKey("YoutubeEntitySample.Models.Video", "YoutuberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}