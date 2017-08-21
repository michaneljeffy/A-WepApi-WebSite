namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.shows")]
    public partial class shows
    {
        public int id { get; set; }

        public sbyte shows_type { get; set; }

        [Required]
        [StringLength(255)]
        public string title { get; set; }

        [Required]
        [StringLength(255)]
        public string cids { get; set; }

        public bool status { get; set; }

        public sbyte is_public { get; set; }

        [Required]
        [StringLength(11)]
        public string shows_from { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string ext { get; set; }

        public sbyte child_type { get; set; }

        public int online_count { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? online_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? offline_at { get; set; }

        public int? created_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        public int max_count { get; set; }

        public int max_machine { get; set; }

        [StringLength(16777215)]
        public string extra_data { get; set; }

        public int? pay_type { get; set; }

        public int? owner_cid { get; set; }

        public int? cid { get; set; }

        public int? secondary_cid { get; set; }

        public int? tertiary_cid { get; set; }

        public int? current_online_count { get; set; }
    }
}
