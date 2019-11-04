namespace Railway.Logic
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ViewContext : DbContext
    {
        public ViewContext()
            : base("name=ViewContext")
        {
        }

        public virtual DbSet<View_route> View_route { get; set; }
        public virtual DbSet<View_tickets> View_tickets { get; set; }
        public virtual DbSet<View_trip> View_trip { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<View_route>()
                .Property(e => e.name_station)
                .IsUnicode(false);

            modelBuilder.Entity<View_route>()
                .Property(e => e.Expr1)
                .IsUnicode(false);

            modelBuilder.Entity<View_tickets>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<View_tickets>()
                .Property(e => e.number_train)
                .IsUnicode(false);

            modelBuilder.Entity<View_tickets>()
                .Property(e => e.name_station)
                .IsUnicode(false);

            modelBuilder.Entity<View_tickets>()
                .Property(e => e.Expr1)
                .IsUnicode(false);

            modelBuilder.Entity<View_trip>()
                .Property(e => e.number_train)
                .IsUnicode(false);

            modelBuilder.Entity<View_trip>()
                .Property(e => e.name_station)
                .IsUnicode(false);

            modelBuilder.Entity<View_trip>()
                .Property(e => e.Expr1)
                .IsUnicode(false);
        }
    }
}
