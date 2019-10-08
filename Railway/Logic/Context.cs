namespace Railway
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<CARRIAGE> CARRIAGEs { get; set; }
        public virtual DbSet<CARRIAGE_TYPE> CARRIAGE_TYPE { get; set; }
        public virtual DbSet<PASSANGER> PASSANGERs { get; set; }
        public virtual DbSet<ROUTE> ROUTEs { get; set; }
        public virtual DbSet<STATION> STATIONs { get; set; }
        public virtual DbSet<TICKET> TICKETs { get; set; }
        public virtual DbSet<TRAIN> TRAINs { get; set; }
        public virtual DbSet<TRAIN_COMPOSITION> TRAIN_COMPOSITION { get; set; }
        public virtual DbSet<TRAIN_TYPE> TRAIN_TYPE { get; set; }
        public virtual DbSet<TRIP> TRIPs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CARRIAGE>()
                .HasMany(e => e.TICKETs)
                .WithRequired(e => e.CARRIAGE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CARRIAGE>()
                .HasMany(e => e.TRAIN_COMPOSITION)
                .WithRequired(e => e.CARRIAGE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CARRIAGE_TYPE>()
                .Property(e => e.type_carriage)
                .IsUnicode(false);

            modelBuilder.Entity<PASSANGER>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<PASSANGER>()
                .Property(e => e.passport)
                .IsUnicode(false);

            modelBuilder.Entity<PASSANGER>()
                .Property(e => e.is_admin)
                .IsFixedLength();

            modelBuilder.Entity<PASSANGER>()
                .HasMany(e => e.TICKETs)
                .WithRequired(e => e.PASSANGER)
                .WillCascadeOnDelete(false);
            /*
            modelBuilder.Entity<ROUTE>()
                .HasMany(e => e.TRIPs)
                .WithRequired(e => e.ROUTE)
                .WillCascadeOnDelete(false);
                */
            modelBuilder.Entity<STATION>()
                .Property(e => e.name_station)
                .IsUnicode(false);

            /*
            modelBuilder.Entity<STATION>()
                .HasMany(e => e.ROUTEs)
                .WithRequired(e => e.STATION)
                .HasForeignKey(e => e.id_start_station)
                .WillCascadeOnDelete(false);
*/
            modelBuilder.Entity<TICKET>()
                .Property(e => e.place)
                .IsUnicode(false);

            modelBuilder.Entity<TICKET>()
                .HasMany(e => e.TRIPs)
                .WithRequired(e => e.TICKET)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRAIN>()
                .Property(e => e.number_train)
                .IsUnicode(false);

            modelBuilder.Entity<TRAIN>()
                .HasMany(e => e.TRAIN_COMPOSITION)
                .WithRequired(e => e.TRAIN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRAIN>()
                .HasMany(e => e.TRIPs)
                .WithRequired(e => e.TRAIN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRAIN_TYPE>()
                .Property(e => e.type_train)
                .IsUnicode(false);

            modelBuilder.Entity<TRIP>()
                .Property(e => e.status)
                .IsUnicode(false);
        }
    }
}
