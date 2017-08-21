namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.bill")]
    public partial class bill
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string out_trade_code { get; set; }

        [Required]
        [StringLength(100)]
        public string transaction_number { get; set; }

        [Required]
        [StringLength(100)]
        public string body { get; set; }

        public int money { get; set; }

        [Required]
        [StringLength(50)]
        public string payment { get; set; }

        public sbyte operate { get; set; }

        public sbyte status { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [Required]
        [StringLength(100)]
        public string open_id { get; set; }

        public int paid_at { get; set; }
    }
}
