namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.game")]
    public partial class game
    {
        public int id { get; set; }

        public int? player_count { get; set; }

        public int? current_player_count { get; set; }

        public int? relationship { get; set; }

        [StringLength(255)]
        public string machine_code { get; set; }

        public int? state { get; set; }

        [StringLength(16777215)]
        public string extra_data { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        public int? activity_id { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? start_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? finished_at { get; set; }
    }
}
