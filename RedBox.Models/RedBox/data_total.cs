namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.data_total")]
    public partial class data_total
    {
        public int id { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? date { get; set; }

        public int? pv { get; set; }

        public int? uv { get; set; }

        public int? user_count { get; set; }

        public int? user_official_count { get; set; }

        public int? printer_count_limit { get; set; }

        public int? printer_count { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        public int? cid { get; set; }

        public int? secondary_cid { get; set; }

        public int? tertiary_cid { get; set; }
    }
}
