namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.lottery_prize_entity")]
    public partial class lottery_prize_entity
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        public short pid { get; set; }

        [Required]
        [StringLength(255)]
        public string prize_code { get; set; }

        public sbyte is_valued { get; set; }

        [Required]
        [StringLength(255)]
        public string img_url { get; set; }

        [Required]
        [StringLength(30)]
        public string reach { get; set; }

        [Required]
        [StringLength(30)]
        public string minus { get; set; }

        public sbyte status { get; set; }

        [Required]
        [StringLength(255)]
        public string mall_id { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        public sbyte? prize_type { get; set; }

        [StringLength(10)]
        public string open_date { get; set; }

        [StringLength(10)]
        public string end_date { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        [StringLength(255)]
        public string scene_text { get; set; }

        public int uid { get; set; }

        [Required]
        [StringLength(20)]
        public string machine_code { get; set; }

        [Required]
        [StringLength(255)]
        public string extra_data { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? get_time { get; set; }

        public sbyte exchanged { get; set; }

        public int round { get; set; }
    }
}
