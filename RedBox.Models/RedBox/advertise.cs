namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.advertise")]
    public partial class advertise
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string promo_name { get; set; }

        public int online_time { get; set; }

        public int offline_time { get; set; }

        public int daily_on_time { get; set; }

        public int daily_off_time { get; set; }

        public int? machine_count { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        public sbyte coupon_type { get; set; }
    }
}
