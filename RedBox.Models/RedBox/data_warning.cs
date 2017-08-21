namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.data_warning")]
    public partial class data_warning
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [StringLength(255)]
        public string code { get; set; }

        [Column(TypeName = "uint")]
        public long? yes_count { get; set; }

        [Column(TypeName = "uint")]
        public long? bef_count { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? warning_date { get; set; }

        public int? city { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        [StringLength(255)]
        public string extra { get; set; }

        public int? cid { get; set; }

        public int? secondary_cid { get; set; }

        public int? tertiary_cid { get; set; }

        public int? owner_cid { get; set; }

        [Column(TypeName = "uint")]
        public long? created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }
    }
}
