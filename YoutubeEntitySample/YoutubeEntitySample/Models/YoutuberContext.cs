using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace YoutubeEntitySample.Models
{
    public class YoutuberContext : DbContext
    {

        public YoutuberContext(DbContextOptions<YoutuberContext> options) : base(options)
        {

        }

        public DbSet<Youtuber> Youtubers { get; set; }
        public DbSet<Video> Videos { get; set; }
    }

    public class Youtuber
    {
        public int Id { get; set; }
        public string ChannelName { get; set; }
        public int SubscriberCount { get; set; }
        public Video Videos { get; set; }
    }

    public class Video
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Duration { get; set; }
        public int YoutuberId { get; set; }
    }
}
