namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.participator_draw")]
    public partial class participator_draw
    {
        public int id { get; set; }

        public int? trophy_id { get; set; }

        public int? jackpot_id { get; set; }

        public int? participator_id { get; set; }

        [StringLength(255)]
        public string participator_type { get; set; }

        [StringLength(255)]
        public string trophy_type { get; set; }

        public int? value_degree { get; set; }

        public bool? is_hint { get; set; }

        public bool? is_applied { get; set; }

        public bool? is_verified { get; set; }

        [StringLength(255)]
        public string verify_code { get; set; }

        [StringLength(16777215)]
        public string extra_data { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "uint")]
        public long? applied_trophy_id { get; set; }

        [StringLength(255)]
        public string event_key { get; set; }
    }
}
