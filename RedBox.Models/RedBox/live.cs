namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.live")]
    public partial class live
    {
        public int id { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [StringLength(20)]
        public string in_id { get; set; }

        public int? type { get; set; }

        public int? is_horizontal { get; set; }

        [StringLength(255)]
        public string location { get; set; }

        public int? online_time { get; set; }

        public int? offline_time { get; set; }

        [StringLength(255)]
        public string qr_code_url { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }
    }
}
