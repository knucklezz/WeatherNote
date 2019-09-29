using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WeatherNote.DAL
{
    public class WeatherNoteContext : DbContext
    {
        public WeatherNoteContext() : base("WeatherNoteContext")
        {

        }

        public DbSet<Models.WeatherNoteDetails> weatherNotes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}