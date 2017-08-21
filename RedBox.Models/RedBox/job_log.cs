namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.job_log")]
    public partial class job_log
    {
        public int id { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [Column("operator")]
        [StringLength(255)]
        public string _operator { get; set; }

        [StringLength(255)]
        public string category { get; set; }

        public int? job_status { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? start_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? done_at { get; set; }

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
