namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.print_log")]
    public partial class print_log
    {
        public int id { get; set; }

        public int? uid { get; set; }

        public int? cid { get; set; }

        [StringLength(256)]
        public string maid { get; set; }

        [StringLength(255)]
        public string code { get; set; }

        [StringLength(255)]
        public string info { get; set; }

        public int? created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? finished_at { get; set; }

        public int status { get; set; }

        public int? ads_id { get; set; }

        [StringLength(256)]
        public string ads_url { get; set; }

        [Column(TypeName = "char")]
        [StringLength(4)]
        public string print_log_from { get; set; }

        public int? statistic_printer_id { get; set; }

        public sbyte print_type { get; set; }
    }
}
