namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.promo_loreal")]
    public partial class promo_loreal
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string machine_code { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        [StringLength(255)]
        public string extra { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }
    }
}