namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.users_order")]
    public partial class users_order
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        public int user_id { get; set; }

        public long out_trade_code { get; set; }

        [Required]
        [StringLength(20)]
        public string machine_code { get; set; }

        public sbyte is_print { get; set; }

        public int money { get; set; }

        [Required]
        [StringLength(255)]
        public string img_url { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }
    }
}
