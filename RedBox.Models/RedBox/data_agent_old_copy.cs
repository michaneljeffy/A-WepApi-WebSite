namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.data_agent_old_copy")]
    public partial class data_agent_old_copy
    {
        public int id { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? date { get; set; }

        [StringLength(255)]
        public string machine_code { get; set; }

        [StringLength(255)]
        public string location { get; set; }

        [StringLength(255)]
        public string market { get; set; }

        public int? user_count { get; set; }

        public int? user_official_count { get; set; }

        public int user_printer_count { get; set; }

        public int? price { get; set; }

        public double? printer_count_limit { get; set; }

        public double? printer_marketfree_count { get; set; }

        public double? printer_count { get; set; }

        public int? in_app_user_count { get; set; }

        public int? in_app_print_count { get; set; }

        [StringLength(255)]
        public string agent_source { get; set; }

        [Required]
        [StringLength(255)]
        public string extra1 { get; set; }

        public int? print_type { get; set; }

        public int? has_run { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        public int? cid { get; set; }

        public int? secondary_cid { get; set; }

        public int? tertiary_cid { get; set; }

        public int? owner_cid { get; set; }
    }
}
