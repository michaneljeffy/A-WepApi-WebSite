namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.data_promo")]
    public partial class data_promo
    {
        public int id { get; set; }

        public int promo_type { get; set; }

        [StringLength(255)]
        public string open_id { get; set; }

        [StringLength(255)]
        public string machine_code { get; set; }

        public int? total_count { get; set; }

        public int? left_count { get; set; }

        [StringLength(255)]
        public string extra { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }
    }
}
