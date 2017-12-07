namespace MVCProjectAttempt1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public class Product
    {
        public Guid Id { get; set; }

        [Required]
       // [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "smallmoney")]
        public decimal Cost { get; set; }

        [Required]
       // [StringLength(50)]
        public string Type { get; set; }
    }
}
