namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.official_account")]
    public partial class official_account
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [Required]
        [StringLength(255)]
        public string account { get; set; }

        [Required]
        [StringLength(20)]
        public string code { get; set; }

        [Required]
        [StringLength(255)]
        public string channel { get; set; }

        public int? top { get; set; }

        [Required]
        [StringLength(255)]
        public string poster_url { get; set; }

        [Required]
        [StringLength(255)]
        public string qrcode_url { get; set; }

        public int free_count { get; set; }

        public int fans_count { get; set; }

        public int fans_count_limit { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        [StringLength(255)]
        public string location { get; set; }

        public int? unit_price { get; set; }

        [StringLength(255)]
        public string agent_source { get; set; }

        public int? only_agent { get; set; }

        public int is_post { get; set; }

        public int? period { get; set; }

        public int? market_free { get; set; }

        [StringLength(150)]
        public string instruction { get; set; }

        [Column(TypeName = "uint")]
        public long coupon_num { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? onlined_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at1 { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        public int is_person { get; set; }

        [StringLength(16777215)]
        public string extra_data { get; set; }

        public bool? is_public { get; set; }

        public int? coin { get; set; }

        [Column(TypeName = "uint")]
        public long? focus_limit { get; set; }

        [StringLength(1024)]
        public string presentation_url { get; set; }

        public int? owner_cid { get; set; }

        public int? cid { get; set; }

        public int? secondary_cid { get; set; }

        public int? tertiary_cid { get; set; }

        public int? orient_sex { get; set; }

        public int? is_core_post { get; set; }

        [Column(TypeName = "uint")]
        public long? online_count { get; set; }
    }
}
