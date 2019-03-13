using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    [Table("@Boxes")]
    public class Box
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BoxNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Destination { get; set; }

        public Box() { }

        public Box(int boxNumber, string destination)
        {
            this.BoxNumber = boxNumber;
            this.Destination = destination;
        }

        override
        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Boxnumber: {0}, Destination: {1}", this.BoxNumber.ToString(), this.Destination);
            return sb.ToString();
        }
    }

    public partial class DbModel : DbContext
    {
        public DbModel() : base("name=DbModel") { }

        public virtual DbSet<Box> Boxes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Box>()
                .Property(e => e.Destination)
                .IsUnicode(false);
        }
    }
}
