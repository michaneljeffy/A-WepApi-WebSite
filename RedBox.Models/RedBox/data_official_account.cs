namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.data_official_account")]
    public partial class data_official_account
    {
        public int id { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? date { get; set; }

        [Required]
        [StringLength(255)]
        public string official_account_code { get; set; }

        public int? pv { get; set; }

        public int? uv { get; set; }

        public int? user_count { get; set; }

        public double? printer_count { get; set; }

        [StringLength(255)]
        public string agent_source { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "uint")]
        public long cid { get; set; }

        [Column(TypeName = "uint")]
        public long secondary_cid { get; set; }

        [Column(TypeName = "uint")]
        public long tertiary_cid { get; set; }

        public int? owner_cid { get; set; }
    }
}
