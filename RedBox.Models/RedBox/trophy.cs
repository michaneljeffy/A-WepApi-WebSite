namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.trophy")]
    public partial class trophy
    {
        public int id { get; set; }

        public int? jackpot_id { get; set; }

        public int? trophyable_id { get; set; }

        [StringLength(255)]
        public string trophyable_type { get; set; }

        [StringLength(255)]
        public string trophy_type { get; set; }

        public int? value_degree { get; set; }

        public int? orient_sex { get; set; }

        [StringLength(255)]
        public string first_category { get; set; }

        [StringLength(255)]
        public string second_category { get; set; }

        public int? left_count { get; set; }

        public int? weight { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? effective_start_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? effective_end_at { get; set; }

        [StringLength(16777215)]
        public string rate_config { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(16777215)]
        public string extra_data { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        public int? day_start { get; set; }

        public int? day_end { get; set; }
    }
}
