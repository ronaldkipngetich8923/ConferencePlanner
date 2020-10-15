using Conference.Data.DataClasses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
    }
}
