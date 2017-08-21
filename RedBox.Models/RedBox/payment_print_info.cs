namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.payment_print_info")]
    public partial class payment_print_info
    {
        public int id { get; set; }

        public int? user_id { get; set; }

        [Required]
        [StringLength(100)]
        public string machine_code { get; set; }

        [Required]
        [StringLength(255)]
        public string img_url { get; set; }

        public int width { get; set; }

        public int height { get; set; }

        [Required]
        [StringLength(50)]
        public string unique_key { get; set; }

        public int amount { get; set; }

        public int unit_price { get; set; }

        public sbyte status { get; set; }

        [Required]
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
