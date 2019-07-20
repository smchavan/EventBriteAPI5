using EventCatalogAPI.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Data
{
    public class EventContext:DbContext
    {
        public EventContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<EventCategory> EventCategories { get; set; }
        public DbSet<EventState> EventStates { get; set; }
        public DbSet<EventLocation> EventLocations { get; set; }
        public DbSet<EventItem> EventItems { get; set; }
        

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventCategory>(ConfigureEventCategory);
            modelBuilder.Entity<EventState>(ConfigureEventState);
            modelBuilder.Entity<EventLocation>(ConfigureEventLocation);
            modelBuilder.Entity<EventItem>(ConfigureEventItem);

        }

        private void ConfigureEventItem(EntityTypeBuilder<EventItem> builder)
        {
            builder.ToTable("Event");

            builder.Property(c => c.Id)
                .IsRequired()
                .ForSqlServerUseSequenceHiLo("event_hilo");

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.Price)
                .IsRequired();

            builder.Property(c => c.Description)
               .IsRequired()
               .HasMaxLength(100);

            builder.Property(c => c.PictureUrl)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.ContactName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.PhoneNumber)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(c => c.EventDateTime)
               .IsRequired();

            builder.HasOne(c => c.EventCategory)
                .WithMany()
                .HasForeignKey(c => c.EventCategoryId);

            builder.HasOne(c => c.EventState)
                .WithMany()
                .HasForeignKey(c => c.EventStateId);

            builder.HasOne(c => c.EventLocation)
                .WithMany()
                .HasForeignKey(c => c.EventLocationId);


        }

        private void ConfigureEventLocation(EntityTypeBuilder<EventLocation> builder)
        {
            builder.ToTable("Event Locations");
            builder.Property(c => c.Id)
                .IsRequired()
                .ForSqlServerUseSequenceHiLo("event_location_hilo");

            builder.Property(c => c.LocationName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.City)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(c => c.Address)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.StateName)
                .IsRequired()
                .HasMaxLength(50);
        }

        private void ConfigureEventState(EntityTypeBuilder<EventState> builder)
        {
            builder.ToTable("Event States");
            builder.Property(c => c.Id)
                .IsRequired()
                .ForSqlServerUseSequenceHiLo("event_state_hilo");

            builder.Property(c => c.State)
                .IsRequired()
                .HasMaxLength(50);
        }

        private void ConfigureEventCategory(EntityTypeBuilder<EventCategory> builder)
        {
            builder.ToTable("Event Categories");
            builder.Property(c => c.Id)
                .IsRequired()
                .ForSqlServerUseSequenceHiLo("event_category_hilo");

            builder.Property(c => c.Category)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
