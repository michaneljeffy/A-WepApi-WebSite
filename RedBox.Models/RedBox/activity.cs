namespace RedBox.Models.RedBox
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("fans_online2.activity")]
    public partial class activity
    {
        public int id { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string game_identity { get; set; }

        [StringLength(1024)]
        public string game_url { get; set; }

        [Column(TypeName = "uint")]
        public long? jackpot_id { get; set; }

        public int? free_count { get; set; }

        [StringLength(255)]
        public string free_scope { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? effective_start_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? effective_end_at { get; set; }

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
