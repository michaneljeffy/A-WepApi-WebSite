namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.coupon")]
    public partial class coupon
    {
        public int id { get; set; }

        [StringLength(255)]
        public string serial_number { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(1024)]
        public string description { get; set; }

        public bool? is_shareable { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? effective_start_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? effective_end_at { get; set; }

        [StringLength(255)]
        public string shop_name { get; set; }

        [StringLength(255)]
        public string logo_url { get; set; }

        public int? total_count { get; set; }

        public int? left_count { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        [StringLength(255)]
        public string value_degree { get; set; }

        public int? orient_sex { get; set; }

        [StringLength(255)]
        public string first_category { get; set; }

        [StringLength(255)]
        public string second_category { get; set; }

        [StringLength(255)]
        public string provider { get; set; }

        [StringLength(255)]
        public string coupon_type { get; set; }

        [StringLength(16777215)]
        public string ext_info { get; set; }

        [StringLength(16777215)]
        public string extra_data { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }
    }
}
