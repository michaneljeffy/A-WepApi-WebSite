namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.user_charge_order")]
    public partial class user_charge_order
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long user_id { get; set; }

        [Required]
        [StringLength(50)]
        public string machine_code { get; set; }

        [Column(TypeName = "uint")]
        public long money { get; set; }

        [Column(TypeName = "uint")]
        public long order_id { get; set; }

        [Required]
        [StringLength(50)]
        public string type { get; set; }

        public sbyte status { get; set; }

        [Required]
        [StringLength(16777215)]
        public string extra_data { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [Required]
        [StringLength(20)]
        public string discount { get; set; }

        [Required]
        [StringLength(50)]
        public string unique_key { get; set; }
    }
}
