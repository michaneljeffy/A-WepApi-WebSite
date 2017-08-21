namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.redbox_log_status")]
    public partial class redbox_log_status
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        public int redbox_id { get; set; }

        public int status { get; set; }

        public int old_status { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(20)]
        public string code { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(50)]
        public string maid { get; set; }

        [Required]
        [StringLength(50)]
        public string version { get; set; }

        public int cid { get; set; }

        public int city { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime end_at { get; set; }

        public int time { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }
    }
}
