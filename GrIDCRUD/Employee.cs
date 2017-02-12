namespace GrIDCRUD
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Employee : DbContext
    {
        public Employee()
            : base("name=Employee")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Employment> Employments { get; set; }
        public virtual DbSet<EventLog> EventLogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
