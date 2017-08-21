namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.activity_privilege")]
    public partial class activity_privilege
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long? user_id { get; set; }

        [Column(TypeName = "uint")]
        public long? activity_id { get; set; }

        [Column(TypeName = "uint")]
        public long? order_id { get; set; }

        public int? privilege_type { get; set; }

        public int? privilege_from { get; set; }

        public int? left_count { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? effective_start_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? effective_end_at { get; set; }

        public bool? is_active { get; set; }

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
