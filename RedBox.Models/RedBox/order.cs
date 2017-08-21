namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.order")]
    public partial class order
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        public int user_id { get; set; }

        [StringLength(20)]
        public string machine_code { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        [StringLength(16777215)]
        public string extra_data { get; set; }

        public sbyte? source { get; set; }

        [Required]
        [StringLength(11)]
        public string pay_type { get; set; }

        public int? money { get; set; }

        [Required]
        [StringLength(255)]
        public string out_trade_code { get; set; }

        public int status { get; set; }

        [StringLength(255)]
        public string body { get; set; }

        [Required]
        [StringLength(20)]
        public string item_key { get; set; }

        [Required]
        [StringLength(255)]
        public string event_key { get; set; }
    }
}
