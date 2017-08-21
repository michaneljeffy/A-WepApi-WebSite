namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.article_print_statistic")]
    public partial class article_print_statistic
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Column(TypeName = "uint")]
        public long coupon_id { get; set; }

        [Required]
        [StringLength(50)]
        public string machine_code { get; set; }

        [Column(TypeName = "uint")]
        public long pre_status { get; set; }

        [Column(TypeName = "uint")]
        public long printer_status { get; set; }

        [Required]
        [StringLength(20)]
        public string out_trade_code { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }
    }
}
