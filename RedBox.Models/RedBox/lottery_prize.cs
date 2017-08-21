namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.lottery_prize")]
    public partial class lottery_prize
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Required]
        [StringLength(255)]
        public string lottery_type { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        public short pid { get; set; }

        [Required]
        [StringLength(255)]
        public string mall_id { get; set; }

        public sbyte is_valued { get; set; }

        [StringLength(30)]
        public string reach { get; set; }

        [StringLength(30)]
        public string minus { get; set; }

        [Column(TypeName = "uint")]
        public long prize_count { get; set; }

        public sbyte? prize_type { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        [Required]
        [StringLength(255)]
        public string img_url { get; set; }

        [Required]
        [StringLength(10)]
        public string open_date { get; set; }

        [Required]
        [StringLength(10)]
        public string end_date { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        [Required]
        [StringLength(255)]
        public string scene_text { get; set; }

        public sbyte status { get; set; }
    }
}
