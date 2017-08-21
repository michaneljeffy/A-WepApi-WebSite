namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.subject_coupon")]
    public partial class subject_coupon
    {
        public int id { get; set; }

        public int? coupon_id { get; set; }

        public int? subject_id { get; set; }

        [StringLength(16777215)]
        public string extra_data { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }
    }
}
